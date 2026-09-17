package com.gorilla.plugin.juliang;

import android.app.Activity;
import android.util.Log;
import com.bytedance.ads.convert.BDConvert;
import com.bytedance.ads.convert.callback.BDConvertLifecycleCallback;
import com.bytedance.ads.convert.config.BDConvertConfig;
import com.bytedance.ads.convert.event.ConvertReportHelper;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class JuLiangAnalyticsWrapper {
    private static final String TAG = "JuLiangWrapper";
    private static boolean debugLogEnabled;

    public interface InitializationCallback {
        void onInitSuccess();
    }

    public static String getSDKVersion() {
        return "2.0.4";
    }

    private JuLiangAnalyticsWrapper() {
    }

    public static void init(Activity activity, boolean z, boolean z2, InitializationCallback initializationCallback) {
        debugLogEnabled = z2;
        BDConvertConfig bDConvertConfig = new BDConvertConfig();
        bDConvertConfig.setAutoSendLaunchEvent(z);
        bDConvertConfig.setEnableLog(z2);
        bDConvertConfig.setLifecycleCallback(new LoggingLifecycleCallback(initializationCallback));
        logDebug("init config, hasConsent: " + z + ", debugLogEnabled: " + z2);
        BDConvert.INSTANCE.init(activity, bDConvertConfig, activity);
    }

    public static void setDebugLogEnabled(boolean z) {
        debugLogEnabled = z;
        BDConvertConfig config = BDConvert.INSTANCE.getConfig();
        if (config != null) {
            config.setEnableLog(z);
        }
    }

    public static void sendLaunchEvent(Activity activity) {
        BDConvert.INSTANCE.sendLaunchEvent(activity);
    }

    public static long getInitTime() {
        return BDConvert.INSTANCE.getInitTime();
    }

    public static void trackEvent(String str, String str2) {
        ConvertReportHelper.onEventV3(str, parseJson(str2));
    }

    public static void trackRegister(String str, boolean z) throws JSONException {
        ConvertReportHelper.onEventRegister(str, z);
    }

    public static void trackPurchase(String str, String str2, String str3, int i, String str4, String str5, boolean z, int i2) throws JSONException {
        ConvertReportHelper.onEventPurchase(str, str2, str3, i, str4, str5, z, i2);
    }

    private static JSONObject parseJson(String str) {
        if (isNullOrEmpty(str)) {
            return new JSONObject();
        }
        try {
            return new JSONObject(str);
        } catch (Exception e) {
            logError("parse json failed: " + e.getMessage());
            return new JSONObject();
        }
    }

    private static boolean isNullOrEmpty(String str) {
        return str == null || str.length() == 0;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void logDebug(String str) {
        if (debugLogEnabled) {
            Log.i(TAG, str);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void logError(String str) {
        Log.e(TAG, str);
    }

    private static final class LoggingLifecycleCallback implements BDConvertLifecycleCallback {
        private boolean initSuccessNotified;
        private final InitializationCallback initializationCallback;

        private LoggingLifecycleCallback(InitializationCallback initializationCallback) {
            this.initializationCallback = initializationCallback;
        }

        @Override // com.bytedance.ads.convert.callback.BDConvertLifecycleCallback
        public void onInitSuccess() {
            InitializationCallback initializationCallback;
            JuLiangAnalyticsWrapper.logDebug("onInitSuccess");
            if (this.initSuccessNotified || (initializationCallback = this.initializationCallback) == null) {
                return;
            }
            this.initSuccessNotified = true;
            initializationCallback.onInitSuccess();
        }

        @Override // com.bytedance.ads.convert.callback.BDConvertLifecycleCallback
        public void onInitFailure(int i, Throwable th) {
            JuLiangAnalyticsWrapper.logError("onInitFailure, reason: " + i + ", error: " + errorMessage(th));
        }

        @Override // com.bytedance.ads.convert.callback.BDConvertLifecycleCallback
        public void onEventSendSuccess(String str, String str2) {
            JuLiangAnalyticsWrapper.logDebug("onEventSendSuccess, eventName: " + str + ", requestId: " + str2);
        }

        @Override // com.bytedance.ads.convert.callback.BDConvertLifecycleCallback
        public void onEventSendFailure(String str, int i, String str2, Throwable th) {
            JuLiangAnalyticsWrapper.logError("onEventSendFailure, eventName: " + str + ", reason: " + i + ", requestId: " + str2 + ", error: " + errorMessage(th));
        }

        @Override // com.bytedance.ads.convert.callback.BDConvertLifecycleCallback
        public void onOtherError(int i, Throwable th) {
            JuLiangAnalyticsWrapper.logError("onOtherError, reason: " + i + ", error: " + errorMessage(th));
        }

        private static String errorMessage(Throwable th) {
            return th == null ? "" : th.getMessage();
        }
    }
}
