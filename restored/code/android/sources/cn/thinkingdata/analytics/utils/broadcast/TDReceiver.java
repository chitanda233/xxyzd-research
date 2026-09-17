package cn.thinkingdata.analytics.utils.broadcast;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Build;
import cn.thinkingdata.analytics.TDFirstEvent;
import cn.thinkingdata.analytics.TDOverWritableEvent;
import cn.thinkingdata.analytics.TDUpdatableEvent;
import cn.thinkingdata.analytics.ThinkingAnalyticsEvent;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.q;
import java.util.Date;
import java.util.TimeZone;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDReceiver extends BroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile TDReceiver f132a;

    public static synchronized TDReceiver a() {
        if (f132a == null) {
            synchronized (TDReceiver.class) {
                if (f132a == null) {
                    f132a = new TDReceiver();
                }
            }
        }
        return f132a;
    }

    public static void a(Context context) {
        IntentFilter intentFilter = new IntentFilter();
        String strD = q.d(context);
        intentFilter.addAction(strD.length() == 0 ? "cn.thinkingdata.receiver" : strD + ".cn.thinkingdata.receiver");
        if (Build.VERSION.SDK_INT >= 33) {
            context.registerReceiver(a(), intentFilter, 2);
        } else {
            context.registerReceiver(a(), intentFilter);
        }
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        ThinkingAnalyticsSDK thinkingAnalyticsSDKSharedInstance;
        JSONObject jSONObject;
        JSONObject jSONObject2;
        TDFirstEvent tDFirstEvent;
        JSONObject jSONObject3;
        int intExtra = intent.getIntExtra("TD_ACTION", 0);
        String stringExtra = intent.getStringExtra("#app_id");
        if (stringExtra == null || stringExtra.length() <= 0 || (thinkingAnalyticsSDKSharedInstance = ThinkingAnalyticsSDK.sharedInstance(context, stringExtra)) == null) {
            return;
        }
        jSONObject = null;
        JSONObject jSONObject4 = null;
        jSONObject = null;
        JSONObject jSONObject5 = null;
        ThinkingAnalyticsEvent tDUpdatableEvent = null;
        switch (intExtra) {
            case 1048578:
                String stringExtra2 = intent.getStringExtra("properties");
                long longExtra = intent.getLongExtra("TD_DATE", 0L);
                String stringExtra3 = intent.getStringExtra("TD_KEY_TIMEZONE");
                if (stringExtra2 != null) {
                    try {
                        jSONObject = new JSONObject(stringExtra2);
                    } catch (JSONException e) {
                        e.printStackTrace();
                        jSONObject = null;
                    }
                } else {
                    jSONObject = null;
                }
                Date date = longExtra != 0 ? new Date(longExtra) : null;
                TimeZone defaultTimeZone = thinkingAnalyticsSDKSharedInstance.mConfig.getDefaultTimeZone();
                if (stringExtra3 != null) {
                    defaultTimeZone = TimeZone.getTimeZone(stringExtra3);
                }
                String stringExtra4 = intent.getStringExtra("#event_name");
                if (date != null) {
                    thinkingAnalyticsSDKSharedInstance.track(stringExtra4, jSONObject, date, defaultTimeZone);
                } else {
                    thinkingAnalyticsSDKSharedInstance.track(stringExtra4, jSONObject);
                }
                break;
            case 1048579:
            case 1048580:
            case 1048581:
                String stringExtra5 = intent.getStringExtra("#event_name");
                String stringExtra6 = intent.getStringExtra("properties");
                long longExtra2 = intent.getLongExtra("TD_DATE", 0L);
                String stringExtra7 = intent.getStringExtra("TD_KEY_TIMEZONE");
                if (stringExtra6 != null) {
                    try {
                        jSONObject2 = new JSONObject(stringExtra6);
                    } catch (JSONException e2) {
                        e2.printStackTrace();
                        jSONObject2 = null;
                    }
                } else {
                    jSONObject2 = null;
                }
                Date date2 = longExtra2 != 0 ? new Date(longExtra2) : null;
                TimeZone timeZone = stringExtra7 != null ? TimeZone.getTimeZone(stringExtra7) : null;
                String stringExtra8 = intent.getStringExtra("TD_KEY_EXTRA_FIELD");
                if (intExtra == 1048579) {
                    tDFirstEvent = new TDFirstEvent(stringExtra5, jSONObject2);
                    if (stringExtra8 != null && stringExtra8.length() > 0) {
                        tDUpdatableEvent = tDFirstEvent;
                        tDUpdatableEvent = tDFirstEvent;
                        tDFirstEvent.setFirstCheckId(stringExtra8);
                        tDUpdatableEvent = tDFirstEvent;
                    }
                } else if (intExtra == 1048581) {
                    tDUpdatableEvent = new TDOverWritableEvent(stringExtra5, jSONObject2, stringExtra8);
                } else if (intExtra == 1048580) {
                    tDUpdatableEvent = new TDUpdatableEvent(stringExtra5, jSONObject2, stringExtra8);
                }
                if (tDUpdatableEvent != null) {
                    tDUpdatableEvent.setEventTime(date2, timeZone);
                    thinkingAnalyticsSDKSharedInstance.track(tDUpdatableEvent);
                }
                break;
            case 1048582:
                String stringExtra9 = intent.getStringExtra("properties");
                if (stringExtra9 != null) {
                    try {
                        jSONObject5 = new JSONObject(stringExtra9);
                    } catch (JSONException e3) {
                        e3.printStackTrace();
                    }
                }
                thinkingAnalyticsSDKSharedInstance.autoTrack(intent.getStringExtra("#event_name"), jSONObject5);
                break;
            default:
                switch (intExtra) {
                    case 2097152:
                        String stringExtra10 = intent.getStringExtra("properties");
                        long longExtra3 = intent.getLongExtra("TD_DATE", 0L);
                        if (stringExtra10 != null) {
                            try {
                                jSONObject3 = new JSONObject(stringExtra10);
                            } catch (JSONException e4) {
                                e4.printStackTrace();
                                jSONObject3 = null;
                            }
                        } else {
                            jSONObject3 = null;
                        }
                        thinkingAnalyticsSDKSharedInstance.user_operations(k.a(intent.getStringExtra("TD_KEY_USER_PROPERTY_SET_TYPE")), jSONObject3, longExtra3 != 0 ? new Date(longExtra3) : null);
                        break;
                    case 2097153:
                        String stringExtra11 = intent.getStringExtra("properties");
                        if (stringExtra11 != null) {
                            try {
                                jSONObject4 = new JSONObject(stringExtra11);
                            } catch (JSONException e5) {
                                e5.printStackTrace();
                            }
                        }
                        thinkingAnalyticsSDKSharedInstance.setSuperProperties(jSONObject4);
                        break;
                    case 2097154:
                        thinkingAnalyticsSDKSharedInstance.login(intent.getStringExtra("#account_id"));
                        break;
                    case 2097155:
                        thinkingAnalyticsSDKSharedInstance.logout();
                        break;
                    case 2097156:
                        thinkingAnalyticsSDKSharedInstance.identify(intent.getStringExtra("#distinct_id"));
                        break;
                    case 2097157:
                        thinkingAnalyticsSDKSharedInstance.flush();
                        break;
                    case 2097158:
                        thinkingAnalyticsSDKSharedInstance.unsetSuperProperty(intent.getStringExtra("properties"));
                        break;
                    case 2097159:
                        thinkingAnalyticsSDKSharedInstance.clearSuperProperties();
                        break;
                }
                break;
        }
    }
}
