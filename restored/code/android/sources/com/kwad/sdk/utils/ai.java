package com.kwad.sdk.utils;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class ai {
    private static boolean bps = false;
    private static boolean bpt = false;
    private static String sAppTag = "";

    public static boolean Vn() {
        return bps;
    }

    public static boolean Vo() {
        return bpt;
    }

    public static void e(Context context, String str, long j) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_pref", str, j);
    }

    public static long ab(Context context, String str) {
        if (context == null) {
            return 0L;
        }
        return b(context, "ksadsdk_pref", str, 0L);
    }

    public static void f(Context context, String str, long j) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_download_package_length", str, j);
    }

    public static long ac(Context context, String str) {
        if (context == null) {
            return 0L;
        }
        return b(context, "ksadsdk_download_package_length", str, 0L);
    }

    public static void g(Context context, String str, String str2) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_download_package_md5", str, str2);
    }

    public static String ad(Context context, String str) {
        return context == null ? "" : b(context, "ksadsdk_download_package_md5", str, "");
    }

    public static String dl(Context context) {
        return context == null ? "" : b(context, "ksadsdk_egid", "KEY_SDK_EGID", "");
    }

    private static String dm(Context context) {
        return context == null ? "" : b(context, "ksadsdk_uaid", "KEY_SDK_UAID", "");
    }

    public static String dn(Context context) {
        return context == null ? "" : b(context, "ksadsdk_uaid_token", "KEY_SDK_UAID_TOKEN", "");
    }

    public static boolean Vp() {
        return c(getContext(), "ksadsdk_uaid_enable", "KEY_SDK_UAID_ENABLE", false);
    }

    public static long Vq() {
        return b(getContext(), "ksadsdk_uaid_expire_sec", "KEY_SDK_UAID_EXPIRE_SEC", 0L);
    }

    private static long Vr() {
        return b(getContext(), "ksadsdk_uaid_create_time", "KEY_SDK_UAID_CREATE_TIME", 0L);
    }

    public static void d(Context context, long j) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_gidExpireTimeMs", "KEY_SDK_EGID", j);
    }

    /* JADX INFO: renamed from: do, reason: not valid java name */
    public static long m182do(Context context) {
        if (context == null) {
            return 0L;
        }
        return b(context, "ksadsdk_gidExpireTimeMs", "KEY_SDK_EGID", 0L);
    }

    public static void ae(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_egid", "KEY_SDK_EGID", str);
    }

    public static void af(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_uaid", "KEY_SDK_UAID", str);
    }

    public static void ag(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_uaid_token", "KEY_SDK_UAID_TOKEN", str);
    }

    public static void e(Context context, long j) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_uaid_create_time", "KEY_SDK_UAID_CREATE_TIME", j);
    }

    public static void e(Context context, boolean z) {
        if (context == null) {
            return;
        }
        b(context, "ksadsdk_uaid_enable", "KEY_SDK_UAID_ENABLE", z);
    }

    public static void f(Context context, long j) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_uaid_expire_sec", "KEY_SDK_UAID_EXPIRE_SEC", j);
    }

    public static void l(Context context, int i) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_config_request", "KEY_CONFIG_REQUEST_FAIL", i);
    }

    public static int dp(Context context) {
        if (context == null) {
            return 0;
        }
        return b(context, "ksadsdk_config_request", "KEY_CONFIG_REQUEST_FAIL", 0);
    }

    public static String dq(Context context) {
        if (context == null) {
            return "";
        }
        String strB = b(context, "ksadsdk_model", "KEY_SDK_MODEL", "");
        bq.j(strB, "ksadsdk_model", "KEY_SDK_MODEL");
        return strB;
    }

    public static void ah(Context context, String str) {
        if (context == null) {
            return;
        }
        a("ksadsdk_model", "KEY_SDK_MODEL", str, true);
    }

    public static String Vs() {
        Context context = getContext();
        return context == null ? "" : b(context, "ksadsdk_interstitial_daily_show_count", "KEY_INTERSTITIAL_DAILY_SHOW_COUNT", "");
    }

    public static void ai(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_interstitial_daily_show_count", "KEY_INTERSTITIAL_DAILY_SHOW_COUNT", str);
    }

    public static void m(Context context, int i) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_AD_SHOW_INTERACT_INTERVAL_SHOW_COUNT", i);
    }

    public static int dr(Context context) {
        if (context == null) {
            return 0;
        }
        return b(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_AD_SHOW_INTERACT_INTERVAL_SHOW_COUNT", 0);
    }

    public static void aj(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_INTERACT_AD_SHOW_INFO", str);
    }

    public static String ds(Context context) {
        return context == null ? "" : b(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_INTERACT_AD_SHOW_INFO", "");
    }

    public static String Vt() {
        Context context = getContext();
        return context == null ? "" : b(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_FULL_AD_JUMP_DIRECT", "");
    }

    public static void ak(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_FULL_AD_JUMP_DIRECT", str);
    }

    public static String Vu() {
        Context context = getContext();
        if (context == null) {
            return "";
        }
        if (bp.WK()) {
            return b(context, "ksadsdk_splash_local_ad_force_active", "KEY_SPLASH_DAILY_SHOW_COUNT", "");
        }
        return b(context, "ksadsdk_splash_daily_show_count", "KEY_SPLASH_DAILY_SHOW_COUNT", "");
    }

    public static void al(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_splash_local_ad_force_active", "KEY_SPLASH_DAILY_SHOW_COUNT", str);
        bp.WJ();
    }

    public static String Vv() {
        Context context = getContext();
        if (context == null) {
            return "";
        }
        if (bp.WM()) {
            return i("ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_AUTO_CALL_APP_CARD_SHOW_COUNT", "");
        }
        return b(context, "ksadsdk_reward_auto_call_app_card_show_count", "KEY_REWARD_AUTO_CALL_APP_CARD_SHOW_COUNT", "");
    }

    public static void am(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_reward_full_ad_jump_direct", "KEY_REWARD_AUTO_CALL_APP_CARD_SHOW_COUNT", str);
        bp.WL();
    }

    public static String Vw() {
        return i("ksadsdk_interstitial_daily_show_count", "KEY_INTERSTITIAL_AUTO_CALL_APP_CARD_SHOW_COUNT", "");
    }

    public static void an(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_interstitial_daily_show_count", "KEY_INTERSTITIAL_AUTO_CALL_APP_CARD_SHOW_COUNT", str);
    }

    public static String dt(Context context) {
        return context == null ? "" : b(context, "ksadsdk_device_sig", "KEY_SDK_DEVICE_SIG", "");
    }

    public static void ao(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_device_sig", "KEY_SDK_DEVICE_SIG", str);
    }

    public static void ap(Context context, final String str) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        i.execute(new bi() { // from class: com.kwad.sdk.utils.ai.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ai.aq(ServiceProvider.getContext(), str);
            }
        });
    }

    public static void aq(Context context, String str) {
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_pref", "appTag", str);
    }

    public static String Vx() {
        if (!TextUtils.isEmpty(sAppTag)) {
            return sAppTag;
        }
        Context context = getContext();
        return context == null ? "" : b(context, "ksadsdk_pref", "appTag", "");
    }

    public static void ar(Context context, String str) {
        if (context == null) {
            return;
        }
        a("ksadsdk_pref", "webview_ua", str, true);
    }

    public static String du(Context context) {
        if (context == null) {
            return "";
        }
        String strI = i("ksadsdk_pref", "webview_ua", "");
        bq.j(strI, "ksadsdk_pref", "webview_ua");
        return strI;
    }

    public static String getEGid() {
        Context context = getContext();
        return context == null ? "" : dl(context);
    }

    public static String Vy() {
        Context context = getContext();
        return context == null ? "" : dm(context);
    }

    public static String Vz() {
        Context context = getContext();
        return context == null ? "" : dn(context);
    }

    public static boolean VA() {
        return !TextUtils.isEmpty(Vz());
    }

    public static boolean VB() {
        return (TextUtils.isEmpty(Vy()) || VC()) ? false : true;
    }

    private static boolean VC() {
        long jCurrentTimeMillis = (System.currentTimeMillis() - Vr()) / 1000;
        long jVq = Vq();
        return jVq != 0 && jCurrentTimeMillis >= jVq;
    }

    public static String dv(Context context) {
        if (bp.WH()) {
            return bp.aE(context.getApplicationContext(), "ksadsdk_sdk_config_data");
        }
        String strI = bq.i("ksadsdk_sdk_config_data", "config_str", "");
        bp.i(context.getApplicationContext(), "ksadsdk_sdk_config_data", strI);
        return strI;
    }

    public static void as(Context context, String str) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        bp.j(context.getApplicationContext(), "ksadsdk_sdk_config_data", str);
    }

    public static long VD() {
        return b("ksadsdk_push_ad_common", "key_push_last_show_time", -1L);
    }

    public static void bb(long j) {
        a("ksadsdk_push_ad_common", "key_push_last_show_time", j);
    }

    public static String VE() {
        return getContext() == null ? "" : i("ksadsdk_install_tips_show_count", "init_install_tips_show_count", "");
    }

    public static void at(Context context, String str) {
        if (context == null) {
            return;
        }
        h("ksadsdk_install_tips_show_count", "init_install_tips_show_count", str);
    }

    public static void VF() {
        a("ksadsdk_perf", "image_load_total", b("ksadsdk_perf", "image_load_total", 0) + 1);
    }

    public static void VG() {
        a("ksadsdk_perf", "image_load_suc", b("ksadsdk_perf", "image_load_suc", 0) + 1);
    }

    public static void VH() {
        a("ksadsdk_perf", "image_load_failed", b("ksadsdk_perf", "image_load_failed", 0) + 1);
    }

    public static void bc(long j) {
        a("ksadsdk_perf", "image_load_complete_count", b("ksadsdk_perf", "image_load_complete_count", 0) + 1);
        a("ksadsdk_perf", "image_load_complete_total", b("ksadsdk_perf", "image_load_complete_total", 0L) + j);
    }

    public static double VI() {
        int iB = b("ksadsdk_perf", "image_load_complete_count", 0);
        long jB = b("ksadsdk_perf", "image_load_complete_total", 0L);
        a("ksadsdk_perf", "image_load_complete_count", 0);
        a("ksadsdk_perf", "image_load_complete_total", 0L);
        if (iB == 0) {
            return 0.0d;
        }
        return jB / ((double) iB);
    }

    public static int VJ() {
        Context context = ServiceProvider.getContext();
        if (context == null) {
            return 0;
        }
        return b(context, "ksadsdk_perf", "ksadsdk_soft_height", 0);
    }

    public static void fM(int i) {
        Context context = ServiceProvider.getContext();
        if (context == null) {
            return;
        }
        a(context, "ksadsdk_perf", "ksadsdk_soft_height", i);
    }

    public static int VK() {
        int iB = b("ksadsdk_perf", "image_load_total", 0);
        com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "imageLoadTotal:" + iB);
        a("ksadsdk_perf", "image_load_total", 0);
        return iB;
    }

    public static int VL() {
        int iB = b("ksadsdk_perf", "image_load_suc", 0);
        com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "imageLoadSuccess:" + iB);
        a("ksadsdk_perf", "image_load_suc", 0);
        return iB;
    }

    public static int VM() {
        int iB = b("ksadsdk_perf", "image_load_failed", 0);
        com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "imageLoadFailed:" + iB);
        a("ksadsdk_perf", "image_load_failed", 0);
        return iB;
    }

    public static void c(Context context, String str, boolean z) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        bps = z;
        bpt = false;
        a("ksadsdk_inner_ec_user_login_bind_info", "inner_ec_login_bind_info", str, true);
    }

    public static String f(Context context, boolean z) {
        if (context == null || bpt) {
            return "";
        }
        if (z) {
            bps = false;
        }
        return i("ksadsdk_inner_ec_user_login_bind_info", "inner_ec_login_bind_info", "");
    }

    public static void g(Context context, boolean z) {
        if (context == null) {
            return;
        }
        bpt = true;
        ay("ksadsdk_inner_ec_user_login_bind_info", "inner_ec_login_bind_info");
    }

    public static void ax(String str, String str2) {
        if (str == null || str2 == null) {
            return;
        }
        a("ksadsdk_reward_task_cache", str, str2, true);
    }

    public static void h(String str, String str2, String str3) {
        Context context = getContext();
        if (context == null) {
            return;
        }
        a(context, str, str2, str3);
    }

    public static String i(String str, String str2, String str3) {
        Context context = getContext();
        return context == null ? str3 : b(context, str, str2, str3);
    }

    public static void a(String str, String str2, String str3, boolean z) {
        Context context = getContext();
        if (context == null) {
            return;
        }
        a(context, str, str2, str3, true);
    }

    public static void a(String str, String str2, long j) {
        Context context = getContext();
        if (context == null) {
            return;
        }
        a(context, str, str2, j);
    }

    public static long b(String str, String str2, long j) {
        Context context = getContext();
        return context == null ? j : b(context, str, str2, j);
    }

    public static void a(String str, String str2, int i) {
        Context context = getContext();
        if (context == null) {
            return;
        }
        a(context, str, str2, i);
    }

    public static int b(String str, String str2, int i) {
        Context context = getContext();
        return context == null ? i : b(context, str, str2, i);
    }

    public static void l(String str, String str2, boolean z) {
        Context context = getContext();
        if (context == null) {
            return;
        }
        b(context, str, str2, z);
    }

    public static boolean m(String str, String str2, boolean z) {
        Context context = getContext();
        return context == null ? z : c(context, str, str2, z);
    }

    public static void ay(String str, String str2) {
        Context context = getContext();
        if (context == null) {
            return;
        }
        h(context, str, str2);
    }

    public static Context getContext() {
        return ServiceProvider.Um();
    }

    public static void a(Context context, String str, String str2, String str3) {
        if (context == null) {
            return;
        }
        if (ah.hM(str)) {
            bq.h(str, str2, str3);
            if (com.kwad.framework.a.a.oV.booleanValue()) {
                com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "putString Sp key:" + str2 + " value:" + str3);
                return;
            }
            return;
        }
        com.kwad.sdk.utils.a.e.aF(context, str).putString(str2, str3);
        if (com.kwad.framework.a.a.oV.booleanValue()) {
            com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "putString key:" + str2 + " value:" + str3);
        }
        ah.av(str2, str3);
    }

    private static void a(Context context, String str, String str2, String str3, boolean z) {
        if (context == null) {
            return;
        }
        if (ah.hM(str)) {
            bq.a(str, str2, str3, z);
            if (com.kwad.framework.a.a.oV.booleanValue()) {
                com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "putString Sp key:" + str2 + " value:" + str3);
                return;
            }
            return;
        }
        com.kwad.sdk.utils.a.e.aF(context, str).putString(str2, str3);
        if (com.kwad.framework.a.a.oV.booleanValue()) {
            com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "putString key:" + str2 + " value:" + str3);
        }
        ah.av(str2, str3);
    }

    public static String b(Context context, String str, String str2, String str3) {
        String string;
        if (context == null) {
            return str3;
        }
        if (ah.hM(str)) {
            string = bq.i(str, str2, str3);
            if (com.kwad.framework.a.a.oV.booleanValue()) {
                com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "getString From Sp key:" + str2 + " value:" + string);
            }
        } else {
            string = com.kwad.sdk.utils.a.e.aF(context, str).getString(str2, str3);
            ah.aw(str2, string);
            if (com.kwad.framework.a.a.oV.booleanValue()) {
                com.kwad.sdk.core.d.c.d("Ks_UnionUtils", "getString key:" + str2 + " value:" + string);
            }
        }
        return com.kwad.sdk.core.a.c.isEncodeKsSdk(string) ? com.kwad.sdk.core.a.c.decodeKsSdk(string) : string;
    }

    public static Map<String, ?> hN(String str) {
        Context context = getContext();
        if (context == null) {
            return null;
        }
        return au(context, str);
    }

    private static Map<String, ?> au(Context context, String str) {
        if (context == null) {
            return null;
        }
        if (ah.hM(str)) {
            SharedPreferences sharedPreferencesIe = bq.ie(str);
            if (sharedPreferencesIe != null) {
                return sharedPreferencesIe.getAll();
            }
            return null;
        }
        return com.kwad.sdk.utils.a.e.aF(context, str).getAll();
    }

    private static void a(Context context, String str, String str2, long j) {
        if (context == null) {
            return;
        }
        if (ah.hM(str)) {
            bq.a(str, str2, j);
        } else {
            com.kwad.sdk.utils.a.e.aF(context, str).putLong(str2, j);
        }
    }

    private static long b(Context context, String str, String str2, long j) {
        if (context == null) {
            return j;
        }
        if (ah.hM(str)) {
            return bq.b(str, str2, j);
        }
        return com.kwad.sdk.utils.a.e.aF(context, str).getLong(str2, j);
    }

    private static void a(Context context, String str, String str2, int i) {
        if (context == null) {
            return;
        }
        if (ah.hM(str)) {
            bq.a(str, str2, i);
        } else {
            com.kwad.sdk.utils.a.e.aF(context, str).putInt(str2, i);
        }
    }

    private static int b(Context context, String str, String str2, int i) {
        if (context == null) {
            return i;
        }
        if (ah.hM(str)) {
            return bq.b(str, str2, i);
        }
        return com.kwad.sdk.utils.a.e.aF(context, str).getInt(str2, i);
    }

    private static void b(Context context, String str, String str2, boolean z) {
        if (context == null) {
            return;
        }
        if (ah.hM(str)) {
            bq.l(str, str2, z);
        } else {
            com.kwad.sdk.utils.a.e.aF(context, str).putBoolean(str2, z);
        }
    }

    private static boolean c(Context context, String str, String str2, boolean z) {
        if (context == null) {
            return z;
        }
        if (ah.hM(str)) {
            return bq.m(str, str2, z);
        }
        return com.kwad.sdk.utils.a.e.aF(context, str).getBoolean(str2, z);
    }

    public static void h(Context context, String str, String str2) {
        if (context == null) {
            return;
        }
        if (ah.hM(str)) {
            bq.ay(str, str2);
        } else {
            com.kwad.sdk.utils.a.e.aF(context, str).remove(str2);
            ah.av(str2, "");
        }
    }

    public static void j(String str, String str2, String str3) {
        if (ah.hM(str2)) {
            bq.j(str, str2, str3);
        }
    }
}
