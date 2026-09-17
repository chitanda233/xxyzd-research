package cn.thinkingdata.analytics;

import android.content.Context;
import android.text.TextUtils;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Iterator;
import java.util.TimeZone;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class ThinkingAnalyticsProxy {

    public interface AutoTrackEventTrackerListener {
        String eventCallback(int i, String str, String str2);
    }

    public interface DynamicSuperPropertiesTrackerListener {
        String getDynamicSuperPropertiesString();
    }

    public static void setCustomerLibInfo(String str, String str2) {
        TDAnalytics.setCustomerLibInfo(str, str2);
    }

    public static void enableTrackLog(boolean z) {
        TDAnalytics.enableLog(z);
    }

    public static void calibrateTime(long j) {
        TDAnalytics.calibrateTime(j);
    }

    public static void calibrateTimeWithNtp(String str) {
        TDAnalytics.calibrateTimeWithNtp(str);
    }

    public static void init(Context context, String str, String str2, int i, String str3, String str4, int i2, String str5) {
        if (context != null) {
            try {
                if (!TextUtils.isEmpty(str) && !TextUtils.isEmpty(str2)) {
                    if (TextUtils.isEmpty(str3)) {
                        str3 = str;
                    }
                    TDConfig tDConfig = TDConfig.getInstance(context, str, str2, str3);
                    if (!TextUtils.isEmpty(str4)) {
                        tDConfig.setDefaultTimeZone(TimeZone.getTimeZone(str4));
                    }
                    if (i == 1 || i == 2) {
                        tDConfig.setMode(TDConfig.TDMode.values()[i]);
                    }
                    if (i2 > 0 && !TextUtils.isEmpty(str5)) {
                        tDConfig.enableEncrypt(i2, str5);
                    }
                    TDAnalytics.init(tDConfig);
                }
            } catch (Exception unused) {
            }
        }
    }

    public static void track(String str, String str2, long j, String str3, String str4) {
        JSONObject jSONObject;
        TimeZone timeZone;
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str4);
            if (tDAnalyticsAPI != null) {
                try {
                    jSONObject = new JSONObject(str2);
                } catch (JSONException unused) {
                    jSONObject = null;
                }
                if (j >= 0 && !TextUtils.isEmpty(str3)) {
                    if (TextUtils.equals(str3, "Local")) {
                        timeZone = TimeZone.getDefault();
                    } else {
                        timeZone = TimeZone.getTimeZone(str3);
                    }
                    tDAnalyticsAPI.track(str, jSONObject, new Date(j), timeZone);
                    return;
                }
                tDAnalyticsAPI.track(str, jSONObject);
            }
        } catch (Exception unused2) {
        }
    }

    public static void trackEvent(int i, String str, String str2, String str3, long j, String str4, String str5) {
        Date date;
        TimeZone timeZone;
        JSONObject jSONObject = null;
        if (j > 0) {
            try {
                date = new Date(j);
            } catch (Exception unused) {
                return;
            }
        } else {
            date = null;
        }
        if (TextUtils.equals(str4, "Local")) {
            timeZone = TimeZone.getDefault();
        } else {
            timeZone = TimeZone.getTimeZone(str4);
        }
        try {
            jSONObject = new JSONObject(str2);
        } catch (Exception unused2) {
        }
        if (i == 0) {
            TDFirstEvent tDFirstEvent = new TDFirstEvent(str, jSONObject);
            tDFirstEvent.setFirstCheckId(str3);
            tDFirstEvent.setEventTime(date, timeZone);
            TDAnalyticsAPI.track(tDFirstEvent, str5);
            return;
        }
        if (i == 1) {
            TDUpdatableEvent tDUpdatableEvent = new TDUpdatableEvent(str, jSONObject, str3);
            tDUpdatableEvent.setEventTime(date, timeZone);
            TDAnalyticsAPI.track(tDUpdatableEvent, str5);
        } else if (i == 2) {
            TDOverWritableEvent tDOverWritableEvent = new TDOverWritableEvent(str, jSONObject, str3);
            tDOverWritableEvent.setEventTime(date, timeZone);
            TDAnalyticsAPI.track(tDOverWritableEvent, str5);
        }
    }

    public static void timeEvent(String str, String str2) {
        TDAnalyticsAPI.timeEvent(str, str2);
    }

    public static void login(String str, String str2) {
        TDAnalyticsAPI.login(str, str2);
    }

    public static void logout(String str) {
        TDAnalyticsAPI.logout(str);
    }

    public static void identify(String str, String str2) {
        TDAnalyticsAPI.setDistinctId(str, str2);
    }

    public static String getDistinctId(String str) {
        return TDAnalyticsAPI.getDistinctId(str);
    }

    public static String getAccountId(String str) {
        return TDAnalyticsAPI.getAccountId(str);
    }

    public static void userSet(String str, long j, String str2) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_set(new JSONObject(str), j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void userUnset(String str, long j, String str2) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_unset(new JSONObject(str), j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void userSetOnce(String str, long j, String str2) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_setOnce(new JSONObject(str), j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void userAdd(String str, long j, String str2) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_add(new JSONObject(str), j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void userDel(long j, String str) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_delete(j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void userAppend(String str, long j, String str2) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_append(new JSONObject(str), j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void userUniqAppend(String str, long j, String str2) {
        try {
            ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
            if (tDAnalyticsAPI != null) {
                tDAnalyticsAPI.user_uniqAppend(new JSONObject(str), j > 0 ? new Date(j) : null);
            }
        } catch (Exception unused) {
        }
    }

    public static void setSuperProperties(String str, String str2) {
        try {
            TDAnalyticsAPI.setSuperProperties(new JSONObject(str), str2);
        } catch (Exception unused) {
        }
    }

    public static void unsetSuperProperty(String str, String str2) {
        TDAnalyticsAPI.unsetSuperProperty(str, str2);
    }

    public static void clearSuperProperties(String str) {
        TDAnalyticsAPI.clearSuperProperties(str);
    }

    public static String getSuperProperties(String str) {
        return TDAnalyticsAPI.getSuperProperties(str).toString();
    }

    public static String getPresetProperties(String str) {
        return TDAnalyticsAPI.getPresetProperties(str).toEventPresetProperties().toString();
    }

    public static void flush(String str) {
        TDAnalyticsAPI.flush(str);
    }

    public static String getDeviceId() {
        return TDAnalytics.getDeviceId();
    }

    public static void setTrackStatus(int i, String str) {
        TDAnalytics.TDTrackStatus tDTrackStatus = TDAnalytics.TDTrackStatus.NORMAL;
        if (i == 1) {
            tDTrackStatus = TDAnalytics.TDTrackStatus.PAUSE;
        } else if (i == 2) {
            tDTrackStatus = TDAnalytics.TDTrackStatus.STOP;
        } else if (i == 3) {
            tDTrackStatus = TDAnalytics.TDTrackStatus.SAVE_ONLY;
        }
        TDAnalyticsAPI.setTrackStatus(tDTrackStatus, str);
    }

    public static String createLightInstance(String str) {
        return TDAnalyticsAPI.lightInstance(str);
    }

    public static void setNetworkType(int i, String str) {
        if (i == 0 || i == 2) {
            TDAnalyticsAPI.setNetworkType(TDAnalytics.TDNetworkType.ALL, str);
        } else if (i == 1) {
            TDAnalyticsAPI.setNetworkType(TDAnalytics.TDNetworkType.WIFI, str);
        }
    }

    public static void enableThirdPartySharing(int i, String str, String str2) {
        HashMap map = new HashMap();
        try {
            JSONObject jSONObject = new JSONObject(str);
            Iterator<String> itKeys = jSONObject.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                map.put(next, jSONObject.opt(next));
            }
        } catch (JSONException unused) {
        }
        if (map.isEmpty()) {
            TDAnalyticsAPI.enableThirdPartySharing(i, str2);
        } else {
            TDAnalyticsAPI.enableThirdPartySharing(i, map, str2);
        }
    }

    public static void setDynamicSuperPropertiesTrackerListener(String str, final DynamicSuperPropertiesTrackerListener dynamicSuperPropertiesTrackerListener) {
        ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str);
        if (tDAnalyticsAPI == null) {
            return;
        }
        tDAnalyticsAPI.setAutoTrackDynamicProperties(new ThinkingAnalyticsSDK.AutoTrackDynamicProperties() { // from class: cn.thinkingdata.analytics.ThinkingAnalyticsProxy.1
            @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.AutoTrackDynamicProperties
            public JSONObject getAutoTrackDynamicProperties() {
                try {
                    String dynamicSuperPropertiesString = dynamicSuperPropertiesTrackerListener.getDynamicSuperPropertiesString();
                    if (dynamicSuperPropertiesString != null) {
                        return new JSONObject(dynamicSuperPropertiesString);
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                }
                return new JSONObject();
            }
        });
    }

    public static void enableAutoTrack(int i, String str, String str2) {
        JSONObject jSONObject;
        try {
            jSONObject = new JSONObject(str);
        } catch (JSONException unused) {
            jSONObject = null;
        }
        TDAnalyticsAPI.enableAutoTrack(i, jSONObject, str2);
    }

    public static void setAutoTrackProperties(int i, String str, String str2) {
        JSONObject jSONObject;
        try {
            jSONObject = new JSONObject(str);
        } catch (JSONException unused) {
            jSONObject = null;
        }
        if (jSONObject == null) {
            return;
        }
        ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str2);
        ArrayList arrayList = new ArrayList();
        if ((i & 1) > 0) {
            arrayList.add(ThinkingAnalyticsSDK.AutoTrackEventType.APP_START);
        }
        if ((i & 2) > 0) {
            arrayList.add(ThinkingAnalyticsSDK.AutoTrackEventType.APP_END);
        }
        if ((i & 32) > 0) {
            arrayList.add(ThinkingAnalyticsSDK.AutoTrackEventType.APP_INSTALL);
        }
        if ((i & 16) > 0) {
            arrayList.add(ThinkingAnalyticsSDK.AutoTrackEventType.APP_CRASH);
        }
        tDAnalyticsAPI.setAutoTrackProperties(arrayList, jSONObject);
    }

    public static void enableAutoTrack(int i, final AutoTrackEventTrackerListener autoTrackEventTrackerListener, final String str) {
        TDAnalyticsAPI.enableAutoTrack(i, new TDAnalytics.TDAutoTrackEventHandler() { // from class: cn.thinkingdata.analytics.ThinkingAnalyticsProxy.2
            @Override // cn.thinkingdata.analytics.TDAnalytics.TDAutoTrackEventHandler
            public JSONObject getAutoTrackEventProperties(int i2, JSONObject jSONObject) {
                try {
                    String name = str;
                    if (TextUtils.isEmpty(name)) {
                        name = TDAnalytics.instance.mConfig.getName();
                    }
                    String strEventCallback = autoTrackEventTrackerListener.eventCallback(i2, name, jSONObject.toString());
                    if (strEventCallback != null) {
                        return new JSONObject(strEventCallback);
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                }
                return new JSONObject();
            }
        }, str);
    }
}
