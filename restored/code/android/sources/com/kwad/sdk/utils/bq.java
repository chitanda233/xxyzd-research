package com.kwad.sdk.utils;

import android.content.SharedPreferences;
import android.text.TextUtils;
import android.util.Log;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
@Deprecated
public class bq {
    static final String TAG = "bq";

    public static SharedPreferences ie(String str) {
        try {
            return ServiceProvider.Um().getSharedPreferences(str, 0);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return null;
        }
    }

    static void a(String str, String str2, int i) {
        SharedPreferences sharedPreferencesIe = ie(str);
        if (sharedPreferencesIe == null) {
            return;
        }
        sharedPreferencesIe.edit().putInt(str2, i).apply();
    }

    static int b(String str, String str2, int i) {
        SharedPreferences sharedPreferencesIe = ie(str);
        return sharedPreferencesIe == null ? i : sharedPreferencesIe.getInt(str2, i);
    }

    static void a(String str, String str2, long j) {
        SharedPreferences sharedPreferencesIe = ie(str);
        if (sharedPreferencesIe == null) {
            return;
        }
        sharedPreferencesIe.edit().putLong(str2, j).apply();
    }

    static long b(String str, String str2, long j) {
        SharedPreferences sharedPreferencesIe = ie(str);
        return sharedPreferencesIe == null ? j : sharedPreferencesIe.getLong(str2, j);
    }

    static void l(String str, String str2, boolean z) {
        SharedPreferences sharedPreferencesIe = ie(str);
        if (sharedPreferencesIe == null) {
            return;
        }
        sharedPreferencesIe.edit().putBoolean(str2, z).apply();
    }

    static boolean m(String str, String str2, boolean z) {
        SharedPreferences sharedPreferencesIe = ie(str);
        return sharedPreferencesIe == null ? z : sharedPreferencesIe.getBoolean(str2, z);
    }

    static void ay(String str, String str2) {
        SharedPreferences sharedPreferencesIe = ie(str);
        if (sharedPreferencesIe == null) {
            return;
        }
        sharedPreferencesIe.edit().remove(str2).apply();
    }

    static void h(String str, String str2, String str3) {
        a(str, str2, str3, false);
    }

    static void a(String str, String str2, String str3, boolean z) {
        try {
            SharedPreferences sharedPreferencesIe = ie(str);
            if (sharedPreferencesIe == null) {
                return;
            }
            if (z && !com.kwad.sdk.core.a.c.isEncodeKsSdk(str3)) {
                sharedPreferencesIe.edit().putString(str2, com.kwad.sdk.core.a.c.encodeKsSdk(str3)).apply();
            } else {
                sharedPreferencesIe.edit().putString(str2, str3).apply();
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    static String i(String str, String str2, String str3) {
        String string;
        try {
            SharedPreferences sharedPreferencesIe = ie(str);
            if (sharedPreferencesIe != null && (string = sharedPreferencesIe.getString(str2, str3)) != null && !TextUtils.isEmpty(string)) {
                return (TextUtils.equals(string, str3) || !com.kwad.sdk.core.a.c.isEncodeKsSdk(string)) ? string : com.kwad.sdk.core.a.c.decodeKsSdk(string);
            }
            return str3;
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
            return "";
        }
    }

    static void j(String str, String str2, String str3) {
        if (com.kwad.sdk.core.a.c.isEncodeKsSdk(str)) {
            return;
        }
        h(str2, str3, com.kwad.sdk.core.a.c.encodeKsSdk(str));
    }

    static <T> void a(String str, Map<String, T> map) {
        SharedPreferences sharedPreferencesIe = ie(str);
        if (sharedPreferencesIe == null) {
            return;
        }
        SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
        for (Map.Entry<String, T> entry : map.entrySet()) {
            try {
                a(editorEdit, entry.getKey(), entry.getValue());
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.e(TAG, Log.getStackTraceString(th));
            }
        }
        editorEdit.apply();
    }

    private static void a(SharedPreferences.Editor editor, String str, Object obj) {
        if (str != null) {
            if (obj instanceof Integer) {
                editor.putInt(str, ((Integer) obj).intValue());
                return;
            }
            if (obj instanceof Long) {
                editor.putLong(str, ((Long) obj).longValue());
                return;
            }
            if (obj instanceof Boolean) {
                editor.putBoolean(str, ((Boolean) obj).booleanValue());
                return;
            }
            if (obj instanceof Float) {
                editor.putFloat(str, ((Float) obj).floatValue());
            } else if (obj instanceof Set) {
                editor.putStringSet(str, (Set) obj);
            } else if (obj instanceof String) {
                editor.putString(str, String.valueOf(obj));
            }
        }
    }
}
