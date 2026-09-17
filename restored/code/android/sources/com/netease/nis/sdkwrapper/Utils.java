package com.netease.nis.sdkwrapper;

import android.content.Context;
import android.os.Looper;
import android.widget.Toast;
import cn.thinkingdata.core.router.TRouterMap;
import com.alipay.sdk.m.y.l;
import com.baidu.mobads.sdk.api.IAdInterListener;
import java.lang.reflect.Field;
import java.lang.reflect.Modifier;

/* JADX INFO: loaded from: classes3.dex */
public class Utils {
    public static native Object rL(Object[] objArr);

    static {
        System.loadLibrary("secsdk");
    }

    private static String doTypeShort(String str) {
        if (str.startsWith("[")) {
            return str.replace(TRouterMap.DOT, "/");
        }
        if (str.equals(IAdInterListener.AdProdType.PRODUCT_INTERSTITIAL)) {
            return "I";
        }
        if (str.equals("float")) {
            return "F";
        }
        if (str.equals("long")) {
            return "J";
        }
        if (str.equals("double")) {
            return "D";
        }
        if (str.equals("short")) {
            return "S";
        }
        if (str.equals("char")) {
            return "C";
        }
        if (str.equals("boolean")) {
            return "Z";
        }
        return str.equals("byte") ? "B" : ("L" + str + l.b).replace(TRouterMap.DOT, "/");
    }

    public static String getFieldSCDesc(Class cls, String str, String str2) {
        while (cls != null) {
            String strVGetFieldSCDesc = vGetFieldSCDesc(cls, str, str2);
            if (strVGetFieldSCDesc != "") {
                return strVGetFieldSCDesc;
            }
            cls = cls.getSuperclass();
        }
        return "";
    }

    private static String vGetFieldSCDesc(Class cls, String str, String str2) {
        try {
            Field[] declaredFields = cls.getDeclaredFields();
            Field.setAccessible(declaredFields, true);
            for (Field field : declaredFields) {
                String strReplace = field.getType().toString().replace("class ", "").replace("interface ", "");
                if (Modifier.isStatic(field.getModifiers()) && field.getName().equals(str) && str2.equals(doTypeShort(strReplace))) {
                    return field.getDeclaringClass().getName().replace(TRouterMap.DOT, "/");
                }
            }
            return "";
        } catch (NoClassDefFoundError unused) {
            return "NoClassDefFoundError";
        }
    }

    public static void showRiskMessage(Context context, String str) {
        if (Looper.myLooper() == Looper.getMainLooper()) {
            Toast.makeText(context, str, 0).show();
            return;
        }
        Looper.prepare();
        Toast.makeText(context, str, 0).show();
        Looper.loop();
    }
}
