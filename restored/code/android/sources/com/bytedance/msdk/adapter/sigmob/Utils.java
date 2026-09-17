package com.bytedance.msdk.adapter.sigmob;

import android.content.Context;
import com.bytedance.msdk.adapter.sigmob.base.config.MApiIMediationViewBinderReversal;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationInitConfig;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationViewBinder;
import com.sigmob.windad.WindAds;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class Utils {
    public static final String VERSION_4_25_14 = "4.25.14";

    private static int a(String str) {
        try {
            return Integer.parseInt(str);
        } catch (NumberFormatException unused) {
            return 0;
        }
    }

    public static MediationViewBinder buildViewBinder(Function function) {
        if (function == null) {
            return null;
        }
        MApiIMediationViewBinderReversal mApiIMediationViewBinderReversal = new MApiIMediationViewBinderReversal(function);
        return new MediationViewBinder.Builder(mApiIMediationViewBinderReversal.getLayoutId()).callToActionId(mApiIMediationViewBinderReversal.getCallToActionId()).addExtras(mApiIMediationViewBinderReversal.getExtras()).descriptionTextId(mApiIMediationViewBinderReversal.getDecriptionTextId()).groupImage1Id(mApiIMediationViewBinderReversal.getGroupImage1Id()).groupImage1Id(mApiIMediationViewBinderReversal.getGroupImage2Id()).groupImage1Id(mApiIMediationViewBinderReversal.getGroupImage3Id()).iconImageId(mApiIMediationViewBinderReversal.getIconImageId()).mainImageId(mApiIMediationViewBinderReversal.getMainImageId()).mediaViewIdId(mApiIMediationViewBinderReversal.getMediaViewId()).logoLayoutId(mApiIMediationViewBinderReversal.getLogoLayoutId()).shakeViewContainerId(mApiIMediationViewBinderReversal.getShakeViewContainerId()).titleId(mApiIMediationViewBinderReversal.getTitleId()).sourceId(mApiIMediationViewBinderReversal.getSourceId()).build();
    }

    public static int compareVersion(String str, String str2) {
        if (str == null && str2 == null) {
            return 0;
        }
        if (str == null) {
            return -1;
        }
        if (str2 == null) {
            return 1;
        }
        String[] strArrSplit = str.split("\\.");
        String[] strArrSplit2 = str2.split("\\.");
        int iMax = Math.max(strArrSplit.length, strArrSplit2.length);
        int i = 0;
        while (i < iMax) {
            int iA = i < strArrSplit.length ? a(strArrSplit[i]) : 0;
            int iA2 = i < strArrSplit2.length ? a(strArrSplit2[i]) : 0;
            if (iA != iA2) {
                return Integer.compare(iA, iA2);
            }
            i++;
        }
        return 0;
    }

    public static float dip2Px(Context context, float f) {
        if (context == null) {
            return 0.0f;
        }
        return (f * context.getResources().getDisplayMetrics().density) + 0.5f;
    }

    public static int dp2px(Context context, float f) {
        if (context == null) {
            return 0;
        }
        return (int) ((f * context.getResources().getDisplayMetrics().density) + 0.5f);
    }

    public static boolean isSdkVersionGe(String str) {
        String version = WindAds.getVersion();
        return (version == null || str == null || compareVersion(version, str) < 0) ? false : true;
    }

    public static void printPrivacyLog(MediationInitConfig mediationInitConfig) {
    }
}
