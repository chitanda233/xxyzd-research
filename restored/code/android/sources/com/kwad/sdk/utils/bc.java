package com.kwad.sdk.utils;

import android.content.Context;
import android.content.res.Resources;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class bc {
    private static String getPackageName(Context context) {
        return ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG() ? "com.kwad.sdk" : context.getPackageName();
    }

    private static int getIdentifier(Context context, String str, String str2) {
        return context.getResources().getIdentifier(str, str2, getPackageName(context));
    }

    public static int getId(Context context, String str) {
        return getIdentifier(context, str, "id");
    }

    public static int getAppIconId(Context context) {
        int i;
        try {
            i = aa.getPackageInfo(context.getApplicationContext(), context.getPackageName(), 64).applicationInfo.icon;
        } catch (Throwable unused) {
            i = 0;
        }
        return i <= 0 ? aD(context, "ksad_notification_small_icon") : i;
    }

    public static int aD(Context context, String str) {
        Resources resourcesDM = dM(context);
        if (resourcesDM == null) {
            resourcesDM = context.getResources();
        }
        return resourcesDM.getIdentifier(str, "drawable", context.getPackageName());
    }

    public static Resources dM(Context context) {
        if (context == null) {
            return null;
        }
        return ServiceProvider.Um().getResources();
    }
}
