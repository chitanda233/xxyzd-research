package com.qq.gdt.action.i;

import android.provider.Settings;
import com.kuaishou.weapon.p0.bo;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Boolean f3083a = null;
    private static String b = "";

    public static void a(JSONObject jSONObject) {
        try {
            if (com.qq.gdt.action.d.a().g() == null) {
                o.a("fillHarmonyInfo getApplicationContext is null  ", new Object[0]);
                jSONObject.putOpt("is_harmony_open", false);
                return;
            }
            boolean z = com.qq.gdt.action.b.a(com.qq.gdt.action.d.a().g()).n() == 0;
            o.a("fillHarmonyInfo harmonyCollect = " + z, new Object[0]);
            jSONObject.putOpt("is_harmony_open", Boolean.valueOf(z));
            if (z) {
                boolean zA = a();
                jSONObject.putOpt("is_harmony_os", Boolean.valueOf(zA));
                if (zA) {
                    jSONObject.putOpt("harmony_version", b());
                    jSONObject.putOpt("harmony_pure_mode", Integer.valueOf(c()));
                }
            }
        } catch (Throwable th) {
            o.c("fillHarmonyInfo error" + th);
        }
    }

    private static boolean a() {
        Boolean bool = f3083a;
        if (bool != null) {
            return bool.booleanValue();
        }
        try {
            Class<?> cls = Class.forName("com.huawei.system.BuildEx");
            f3083a = Boolean.valueOf("harmony".equals(cls.getMethod("getOsBrand", new Class[0]).invoke(cls, new Object[0])));
        } catch (Throwable th) {
            o.a("isHarmonyOS" + th, new Object[0]);
            f3083a = false;
        }
        return f3083a.booleanValue();
    }

    private static String b() {
        if (!a()) {
            return "";
        }
        if (!v.a(b)) {
            return b;
        }
        try {
            Class<?> cls = Class.forName("android.os.SystemProperties");
            b = (String) cls.getDeclaredMethod("get", String.class).invoke(cls, com.alipay.sdk.m.d.a.b);
            o.a("getHarmonyInfoFromSystemProperties value: " + b, new Object[0]);
        } catch (Throwable th) {
            b = bo.e;
            o.a("HarmonyOS getVersion" + th, new Object[0]);
        }
        return b;
    }

    private static int c() {
        try {
            if (com.qq.gdt.action.d.a().g() != null) {
                return Settings.Secure.getInt(com.qq.gdt.action.d.a().g().getContentResolver(), "pure_mode_state", -1);
            }
            return -1;
        } catch (Throwable th) {
            o.a("HarmonyOS getPureMode" + th, new Object[0]);
            return -1;
        }
    }
}
