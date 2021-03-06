
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class AppTracking
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.")]
            public static DataItem appInstallerId = new DataItem("appInstallerId");
                                      
            [DescriptionAttribute("The version of the application.")]
            public static DataItem appVersion = new DataItem("appVersion");
                                      
            [DescriptionAttribute("The name of the application.")]
            public static DataItem appName = new DataItem("appName");
                                      
            [DescriptionAttribute("The ID of the application.")]
            public static DataItem appId = new DataItem("appId");
                                      
            [DescriptionAttribute("The name of the screen.")]
            public static DataItem screenName = new DataItem("screenName");
                                      
            [DescriptionAttribute("The number of screenviews per session reported as a string. Can be useful for historgrams.")]
            public static DataItem screenDepth = new DataItem("screenDepth");
                                      
            [DescriptionAttribute("The name of the first screen viewed.")]
            public static DataItem landingScreenName = new DataItem("landingScreenName");
                                      
            [DescriptionAttribute("The name of the screen when the user exited the application.")]
            public static DataItem exitScreenName = new DataItem("exitScreenName");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The total number of screenviews.")]
            public static DataItem screenviews = new DataItem("screenviews");
                                      
            [DescriptionAttribute("The number of different (unique) screenviews within a session.")]
            public static DataItem uniqueScreenviews = new DataItem("uniqueScreenviews");
                                      
            [DescriptionAttribute("The time spent viewing the current screen.")]
            public static DataItem timeOnScreen = new DataItem("timeOnScreen");
                                      
            [DescriptionAttribute("The average amount of time users spent on a screen in seconds.")]
            public static DataItem avgScreenviewDuration = new DataItem("avgScreenviewDuration");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average number of screenviews per session. (ga:screenviews / ga:visits ) ")]
            public static DataItem screenviewsPerSession = new DataItem("screenviewsPerSession");
                                      
            }
        }
    }
}
