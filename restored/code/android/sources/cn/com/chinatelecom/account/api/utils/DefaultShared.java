package cn.com.chinatelecom.account.api.utils;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public final class DefaultShared {
    public static final String KEY_DIFFERENCE_TIME_FOR_SERVER = "key_difference_time";

    private static String getSharedPreferenceDataName(Context context) {
        return "ct_account_api_sdk";
    }

    private static SharedPreferences getSpf(Context context) {
        return context.getSharedPreferences(getSharedPreferenceDataName(context), 0);
    }

    public static void putBoolean(Context context, String str, boolean z) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        try {
            getSpf(context).edit().putBoolean(str, z).commit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void remove(Context context, String str) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        try {
            getSpf(context).edit().remove(str).commit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void putFloat(Context context, String str, float f) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        try {
            getSpf(context).edit().putFloat(str, f).commit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void putInt(Context context, String str, int i) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        try {
            getSpf(context).edit().putInt(str, i).commit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static boolean putLong(Context context, String str, long j) {
        if (context == null || TextUtils.isEmpty(str)) {
            return false;
        }
        try {
            return getSpf(context).edit().putLong(str, j).commit();
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }

    public static void putString(Context context, String str, String str2) {
        if (context == null || TextUtils.isEmpty(str)) {
            return;
        }
        try {
            getSpf(context).edit().putString(str, str2).commit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void putMap(Context context, Map<String, ?> map) {
        if (context == null || map == null) {
            return;
        }
        try {
            if (map.size() == 0) {
                return;
            }
            SharedPreferences.Editor editorEdit = getSpf(context).edit();
            for (Map.Entry<String, ?> entry : map.entrySet()) {
                if (entry.getValue() instanceof Boolean) {
                    editorEdit.putBoolean(entry.getKey(), ((Boolean) entry.getValue()).booleanValue());
                } else if (entry.getValue() instanceof Float) {
                    editorEdit.putFloat(entry.getKey(), ((Float) entry.getValue()).floatValue());
                } else if (entry.getValue() instanceof Integer) {
                    editorEdit.putInt(entry.getKey(), ((Integer) entry.getValue()).intValue());
                } else if (entry.getValue() instanceof Long) {
                    editorEdit.putLong(entry.getKey(), ((Long) entry.getValue()).longValue());
                } else if (entry.getValue() instanceof String) {
                    editorEdit.putString(entry.getKey(), (String) entry.getValue());
                }
            }
            editorEdit.commit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static boolean getBoolean(Context context, String str, boolean z) {
        if (context != null && !TextUtils.isEmpty(str)) {
            try {
                return getSpf(context).getBoolean(str, z);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return z;
    }

    public static float getFloat(Context context, String str, float f) {
        if (context != null && !TextUtils.isEmpty(str)) {
            try {
                return getSpf(context).getFloat(str, f);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return f;
    }

    public static int getInt(Context context, String str, int i) {
        if (context != null && !TextUtils.isEmpty(str)) {
            try {
                return getSpf(context).getInt(str, i);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return i;
    }

    public static long getLong(Context context, String str, long j) {
        if (context != null && !TextUtils.isEmpty(str)) {
            try {
                return getSpf(context).getLong(str, j);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return j;
    }

    public static String getString(Context context, String str, String str2) {
        if (context != null && !TextUtils.isEmpty(str)) {
            try {
                return getSpf(context).getString(str, str2);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return str2;
    }

    public static boolean isContainKey(Context context, String str) {
        if (context == null || TextUtils.isEmpty(str)) {
            return false;
        }
        try {
            return getSpf(context).contains(str);
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }
}
