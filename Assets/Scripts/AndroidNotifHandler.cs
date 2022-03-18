using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class AndroidNotifHandler : MonoBehaviour
{
#if UNITY_ANDROID
    private const string channelId = "notification_channel";
    public void ScheduleNotification(DateTime dateTime)
    {
        AndroidNotificationChannel notificatonChannel = new AndroidNotificationChannel
        {
            Id = channelId,
            Name = "Notification Channel",
            Description = " Skuuuuuu",
            Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notificatonChannel);

        AndroidNotification notif = new AndroidNotification
        {
            Title = "Energy Recharged",
            Text = " Your energy has completely recharged, go drive on the track",
            SmallIcon = "defaault",
            LargeIcon = "default",
            FireTime = dateTime
        };

        AndroidNotificationCenter.SendNotification(notif, channelId);
    }
#endif
}
