package com.kwad.sdk;

import android.content.Context;
import android.os.SystemClock;
import android.util.Log;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.sdk.api.KsAdSDK;
import com.kwad.sdk.api.SdkConfig;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class q {
    private static long aGB;
    private static boolean aGS;

    public static void Hq() {
        if (aGS) {
            return;
        }
        aGS = true;
        aGB = SystemClock.elapsedRealtime();
    }

    public static void s(Throwable th) {
        a(th, Log.getStackTraceString(th));
    }

    public static void a(Throwable th, String str) {
        try {
            p.a(com.kwai.adclient.kscommerciallogger.model.a.buw, str);
            com.kwad.components.core.d.a.reportSdkCaughtException(th);
        } catch (Throwable unused) {
        }
        bh(ServiceProvider.Um());
        com.kwad.sdk.core.d.c.d("SDKRevertHelper", "onInitError revert");
    }

    public static void bg(Context context) {
        long jElapsedRealtime = SystemClock.elapsedRealtime() - aGB;
        com.kwad.sdk.core.d.c.d("SDKRevertHelper", "onException revert time: " + jElapsedRealtime);
        if (jElapsedRealtime < ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT) {
            bh(context);
        }
    }

    private static void bh(Context context) {
        try {
            context.getSharedPreferences("kssdk_api_pref", 0).edit().putString("curversion", "").putBoolean("initFail", true).apply();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    public static void bi(Context context) {
        try {
            context.getSharedPreferences("kssdk_api_pref", 0).edit().putBoolean("initFail", false).apply();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    public static boolean bj(Context context) {
        try {
            return context.getSharedPreferences("kssdk_api_pref", 0).getBoolean("initFail", false);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return false;
        }
    }

    private static String b(Context context, String str, String str2) {
        try {
            return context.getSharedPreferences("kssdk_api_pref", 0).getString(str, str2);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return str2;
        }
    }

    public static void checkInitSDK(Context context) {
        try {
            if (o.GE().FJ()) {
                return;
            }
            KsAdSDK.init(context, bk(context));
        } catch (Throwable th) {
            com.kwad.components.core.d.a.reportSdkCaughtException(th);
        }
    }

    private static SdkConfig bk(Context context) {
        SdkConfig sdkConfigCreate;
        try {
            sdkConfigCreate = SdkConfig.create(b(context, "sdkconfig", ""));
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            sdkConfigCreate = null;
        }
        return sdkConfigCreate == null ? new SdkConfig.Builder().build() : sdkConfigCreate;
    }
}
