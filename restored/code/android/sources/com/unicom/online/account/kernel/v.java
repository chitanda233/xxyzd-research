package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Build;
import android.text.TextUtils;
import java.util.UUID;

/* JADX INFO: loaded from: classes4.dex */
public abstract class v {
    public static String b() {
        return "设备信息如下：\n手机厂商 = " + Build.BRAND + "\n手机型号= " + Build.MODEL + "\n安卓版本 = " + Build.VERSION.RELEASE + "\n设备名称 = " + Build.DEVICE + "\n主板名称 = " + Build.BOARD + "\n生产制造商 = " + Build.MANUFACTURER + "\n";
    }

    public static void b(Context context) {
        String string;
        try {
            string = context.getSharedPreferences("cu_auth", 0).getString("auth02", "");
        } catch (Exception e) {
            as.b(e);
            string = "";
        }
        if (TextUtils.isEmpty(string)) {
            String strB = au.b(UUID.randomUUID().toString().replace("-", "") + System.currentTimeMillis());
            try {
                SharedPreferences.Editor editorEdit = context.getSharedPreferences("cu_auth", 0).edit();
                editorEdit.putString("auth02", strB);
                editorEdit.commit();
            } catch (Exception e2) {
                as.b(e2);
            }
        }
    }
}
