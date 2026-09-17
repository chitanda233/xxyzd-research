package com.kwad.sdk.a.a;

import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    public static String H(AdInfo adInfo) {
        return com.kwad.sdk.core.config.e.KE().replace("[appname]", adInfo.adBaseInfo.appName).replace("[appsize]", com.kwad.components.core.t.e.a(adInfo.adBaseInfo.packageSize, true)).replace("[appver]", adInfo.adBaseInfo.appVersion);
    }

    public static String HD() {
        String strKF = com.kwad.sdk.core.config.e.KF();
        return TextUtils.isEmpty(strKF) ? "安装" : strKF;
    }

    public static String HE() {
        String strKG = com.kwad.sdk.core.config.e.KG();
        return TextUtils.isEmpty(strKG) ? "取消" : strKG;
    }
}
