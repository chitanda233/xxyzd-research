package com.kwad.sdk.utils;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Build;
import com.byazt.bv.BaseConstants;
import com.bykv.vk.component.ttvideo.player.C;

/* JADX INFO: loaded from: classes3.dex */
public final class k {
    private static String boy = Build.BRAND;
    private static String boz = BaseConstants.ROM_OPPO_UPPER_CONSTANT;
    private static String boA = "vivo";
    private static String boB = "Xiaomi";
    private static String boC = "Meizu";
    private static String boD = "HUAWEI";
    private static String boE = "HONOR";

    public static void cU(Context context) {
        Intent intentCV;
        if (context == null || (intentCV = cV(context)) == null) {
            return;
        }
        try {
            context.startActivity(intentCV);
        } catch (Exception unused) {
            Intent intent = new Intent("android.settings.APPLICATION_DETAILS_SETTINGS");
            intent.setData(Uri.parse("package:" + context.getPackageName()));
            context.startActivity(intent);
        }
    }

    private static Intent cV(Context context) {
        Intent intent;
        if (UG()) {
            return R(context, UL());
        }
        if (UH() || UI()) {
            intent = new Intent();
            intent.setFlags(C.ENCODING_PCM_MU_LAW);
            intent.putExtra("packageName", context.getPackageName());
            intent.setComponent(new ComponentName("com.huawei.systemmanager", "com.huawei.permissionmanager.ui.MainActivity"));
        } else if (UE()) {
            intent = new Intent("com.meizu.safe.security.SHOW_APPSEC");
            intent.addCategory("android.intent.category.DEFAULT");
            intent.putExtra("packageName", context.getPackageName());
        } else if (UJ() || UK()) {
            intent = new Intent();
            intent.setFlags(C.ENCODING_PCM_MU_LAW);
            intent.putExtra("packageName", context.getPackageName());
            intent.setComponent(new ComponentName("com.color.safecenter", "com.color.safecenter.permission.PermissionManagerActivity"));
        } else if (UF()) {
            intent = new Intent("android.intent.action.MAIN");
            intent.setFlags(C.ENCODING_PCM_MU_LAW);
            intent.putExtra("packageName", context.getPackageName());
            intent.setComponent(new ComponentName("com.qihoo360.mobilesafe", "com.qihoo360.mobilesafe.ui.index.AppEnterActivity"));
        } else {
            intent = new Intent("android.settings.APPLICATION_DETAILS_SETTINGS");
            intent.setData(Uri.parse("package:" + context.getPackageName()));
        }
        return intent;
    }

    private static Intent R(Context context, String str) {
        if ("V5".equals(str)) {
            return new Intent("android.settings.APPLICATION_DETAILS_SETTINGS", Uri.parse("package:" + context.getPackageName()));
        }
        if ("V6".equals(str) || "V7".equals(str)) {
            Intent intent = new Intent("miui.intent.action.APP_PERM_EDITOR");
            intent.setClassName("com.miui.securitycenter", "com.miui.permcenter.permissions.AppPermissionsEditorActivity");
            intent.putExtra("extra_pkgname", context.getPackageName());
            return intent;
        }
        Intent intent2 = new Intent("miui.intent.action.APP_PERM_EDITOR");
        intent2.setClassName("com.miui.securitycenter", "com.miui.permcenter.permissions.PermissionsEditorActivity");
        intent2.putExtra("extra_pkgname", context.getPackageName());
        return intent2;
    }

    private static boolean UE() {
        String str = "";
        try {
            Class<?> cls = Class.forName("android.os.SystemProperties");
            str = (String) cls.getMethod("get", String.class, String.class).invoke(cls, "ro.build.display.id", "");
        } catch (Exception e) {
            e.printStackTrace();
        }
        return str.toLowerCase().contains("flyme");
    }

    private static boolean UF() {
        return "QIKU".equals(Build.MANUFACTURER.toUpperCase()) || "360".equals(Build.MANUFACTURER.toUpperCase());
    }

    private static boolean UG() {
        return boy.equalsIgnoreCase(boB);
    }

    public static boolean UH() {
        return boy.equalsIgnoreCase(boD);
    }

    public static boolean UI() {
        return boy.equalsIgnoreCase(boE);
    }

    private static boolean UJ() {
        return boy.equalsIgnoreCase(boz);
    }

    private static boolean UK() {
        return boy.equalsIgnoreCase(boA);
    }

    private static String UL() {
        return ar("ro.miui.ui.version.name", "");
    }

    private static String ar(String str, String str2) {
        try {
            Class<?> cls = Class.forName("android.os.SystemProperties");
            return (String) cls.getMethod("get", String.class, String.class).invoke(cls, str, str2);
        } catch (Exception unused) {
            return str2;
        }
    }
}
