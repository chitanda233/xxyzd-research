package com.cmic.gen.sdk.a;

import android.text.TextUtils;
import com.cmic.gen.sdk.f.l;

/* JADX INFO: compiled from: UmcConfigUtil.java */
/* JADX INFO: loaded from: classes2.dex */
class d {
    static boolean a() {
        return System.currentTimeMillis() >= l.a("sso_config_xf", "client_valid", 0L);
    }

    static boolean a(boolean z) {
        return "1".equals(l.a("sso_config_xf", "CLOSE_IPV4_LIST", !z ? "0" : "1"));
    }

    static boolean b(boolean z) {
        return "1".equals(l.a("sso_config_xf", "CLOSE_IPV6_LIST", !z ? "0" : "1"));
    }

    static boolean c(boolean z) {
        String str = !z ? "0" : "1";
        return "1".equals(l.a("sso_config_xf", "CLOSE_M008_APPID_LIST", str)) || "1".equals(l.a("sso_config_xf", "CLOSE_M008_SDKVERSION_LIST", str));
    }

    static String a(String str) {
        String strA = l.a("sso_config_xf", "config_host", (String) null);
        return TextUtils.isEmpty(strA) ? str : strA;
    }

    static String b(String str) {
        String strA = l.a("sso_config_xf", "https_get_phone_scrip_host", (String) null);
        return TextUtils.isEmpty(strA) ? str : strA;
    }

    static String c(String str) {
        String strA = l.a("sso_config_xf", "logHost", "");
        return TextUtils.isEmpty(strA) ? str : strA;
    }

    static boolean d(boolean z) {
        return l.a("sso_config_xf", "CLOSE_FRIEND_WAPKS", z ? "CU" : "").contains("CU");
    }

    static boolean e(boolean z) {
        return l.a("sso_config_xf", "CLOSE_FRIEND_WAPKS", z ? "CT" : "").contains("CT");
    }

    static boolean f(boolean z) {
        return "1".equals(l.a("sso_config_xf", "CLOSE_LOGS_VERSION", z ? "1" : "0"));
    }

    static int a(int i) {
        return l.a("sso_config_xf", "maxFailedLogTimes", i);
    }

    static int b(int i) {
        return l.a("sso_config_xf", "pauseTime", i);
    }
}
