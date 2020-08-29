// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using DesktopNotifications;
using DesktopNotifications.Services;
using Microsoft.QueryStringDotNET;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VocabularyReminder.DataAccessLibrary;

namespace VocabularyReminder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static int GlobalWordId = 0;
        public static bool isRandomWords = false;
        public static bool isShowPopup = false;
        public static DateTime LastReaction;

        protected override void OnStartup(StartupEventArgs e)
        {
            DataAccess.InitializeDatabase();

            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated += ToastNotificationManagerCompat_OnActivated;

            // If launched from a toast
            // This launch arg was specified in our WiX installer where we register the LocalServer32 exe path.
            if (ToastNotificationManagerCompat.WasCurrentProcessToastActivated())
            {
                // Our NotificationActivator code will run after this completes,
                // and will show a window if necessary.
            }

            else
            {
                // Show the window
                // In App.xaml, be sure to remove the StartupUri so that a window doesn't
                // get created by default, since we're creating windows ourselves (and sometimes we
                // don't want to create a window if handling a background activation).
                new MainWindow().Show();
            }

            base.OnStartup(e);
        }

        private void ToastNotificationManagerCompat_OnActivated(ToastNotificationActivatedEventArgsCompat e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                if (e.Argument.Length == 0)
                {
                    //OpenWindowIfNeeded();
                    return;
                }

                // Parse the query string (using NuGet package QueryString.NET)
                QueryString args = QueryString.Parse(e.Argument);

                string main_action;
                args.TryGetValue("action", out main_action);
                // See what action is being requested 
                App.LastReaction = DateTime.Now;
                Vocabulary _item;
                switch (main_action)
                {
                    //case "reload":
                    //    App.GlobalWordId = int.Parse(args["WordId"]);
                    //    var _item = DataAccess.GetVocabularyById(App.GlobalWordId);
                    //    VocabularyToast.loadByVocabulary(_item);
                    //    _item = null;
                    //    break;
                    case "play":
                        App.GlobalWordId = int.Parse(args["WordId"]);
                        int playId = int.Parse(args["PlayId"]);
                        if (App.GlobalWordId > 0)
                        {
                            string _mp3Url;
                            if (VocabularyToast.reloadLastToast())
                            {
                                _mp3Url = args["PlayUrl"];
                            }
                            else
                            {
                                _item = DataAccess.GetVocabularyById(App.GlobalWordId);
                                VocabularyToast.showToastByVocabularyItem(_item);
                                if (playId == 2)
                                {
                                    _mp3Url = _item.PlayURL2;
                                }
                                else
                                {
                                    _mp3Url = _item.PlayURL;
                                }
                            }

                            if (!String.IsNullOrEmpty(_mp3Url))
                            {
                                Task.Run(() => Mp3.PlayFile(_mp3Url));
                            }
                        }
                        break;

                    case "next":
                        App.GlobalWordId = int.Parse(args["WordId"]);
                        if (App.isRandomWords)
                        {
                            _item = DataAccess.GetRandomVocabulary(App.GlobalWordId);
                        }
                        else
                        {
                            _item = DataAccess.GetNextVocabulary(App.GlobalWordId);
                        }

                        if (_item.Id == 0)
                        {
                            _item = DataAccess.GetFirstVocabulary();
                        }
                        App.GlobalWordId = _item.Id;
                        VocabularyToast.showToastByVocabularyItem(_item);
                        _item = null;
                        break;

                    case "view":
                        App.GlobalWordId = int.Parse(args["WordId"]);
                        string url = args["url"];
                        System.Diagnostics.Process.Start(url);
                        break;

                    case "delete":
                        App.GlobalWordId = int.Parse(args["WordId"]);
                        DataAccess.UpdateStatus(App.GlobalWordId, 0);  // skip this word
                        break;

                    case "nextdelete":
                        App.GlobalWordId = int.Parse(args["WordId"]);
                        DataAccess.UpdateStatus(App.GlobalWordId, 0);  // skip this word

                        if (App.isRandomWords)
                        {
                            _item = DataAccess.GetRandomVocabulary(App.GlobalWordId);
                        }
                        else
                        {
                            _item = DataAccess.GetNextVocabulary(App.GlobalWordId);
                        }

                        if (_item.Id == 0)
                        {
                            _item = DataAccess.GetFirstVocabulary();
                        }
                        App.GlobalWordId = _item.Id;
                        VocabularyToast.showToastByVocabularyItem(_item);
                        _item = null;
                        break;
                }
            });
        }
    }
}
