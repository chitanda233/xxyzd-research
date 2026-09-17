package com.gorilla.datanexus;

import android.content.Context;
import android.util.Log;
import com.qq.gdt.action.ActionUtils;
import com.qq.gdt.action.ChannelType;
import com.qq.gdt.action.GDTAction;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class DataNexusBridge {
    private static final String TAG = "GorillaDataNexus";

    private static String valueOrEmpty(String str) {
        return str == null ? "" : str;
    }

    private DataNexusBridge() {
    }

    public static boolean init(Context context, String str, String str2, int i, String str3, boolean z, boolean z2) {
        if (context == null) {
            Log.w(TAG, "init skipped: context is null");
            return false;
        }
        Log.i(TAG, "init start: channel=" + i + ", anidEnabled=" + z + ", autoStartEnabled=" + z2);
        GDTAction.setAnidEnable(z);
        GDTAction.setAutoStartEnable(z2);
        GDTAction.init(context.getApplicationContext(), str, str2, toChannelType(i), valueOrEmpty(str3));
        GDTAction.start();
        Log.i(TAG, "init completed");
        return true;
    }

    public static void setUserUniqueId(String str) {
        Log.d(TAG, "setUserUniqueId called: hasValue=" + ((str == null || str.isEmpty()) ? false : true));
        GDTAction.setUserUniqueId(str);
    }

    public static void track(String str, String str2) {
        Log.d(TAG, "track: actionType=" + valueOrEmpty(str) + ", hasParameters=" + ((str2 == null || str2.isEmpty()) ? false : true));
        if (str2 == null || str2.isEmpty()) {
            GDTAction.logAction(str);
            return;
        }
        try {
            GDTAction.logAction(str, new JSONObject(str2));
        } catch (JSONException e) {
            Log.e(TAG, "track failed: invalid JSON parameters", e);
            throw new IllegalArgumentException("DataNexus 行为参数不是有效 JSON", e);
        }
    }

    public static void onRegister(String str, boolean z) {
        Log.d(TAG, "onRegister: method=" + valueOrEmpty(str) + ", isSuccess=" + z);
        ActionUtils.onRegister(str, z);
    }

    public static void onPurchase(String str, String str2, String str3, int i, String str4, String str5, int i2, boolean z) {
        Log.d(TAG, "onPurchase: contentId=" + valueOrEmpty(str3) + ", value=" + i2 + ", isSuccess=" + z);
        ActionUtils.onPurchase(str, str2, str3, i, str4, str5, i2, z);
    }

    public static void onShare(String str, boolean z) {
        Log.d(TAG, "onShare: channel=" + valueOrEmpty(str) + ", isSuccess=" + z);
        ActionUtils.onShare(str, z);
    }

    public static void onCreateRole(String str) {
        Log.d(TAG, "onCreateRole: hasRoleName=" + ((str == null || str.isEmpty()) ? false : true));
        ActionUtils.onCreateRole(str);
    }

    public static void onQuestFinish(String str, String str2, String str3, int i, String str4, boolean z) {
        Log.d(TAG, "onQuestFinish: questId=" + valueOrEmpty(str) + ", isSuccess=" + z);
        ActionUtils.onQuestFinish(str, str2, str3, i, str4, z);
    }

    public static void onUpdateLevel(int i) {
        Log.d(TAG, "onUpdateLevel: level=" + i);
        ActionUtils.onUpdateLevel(i);
    }

    public static void onViewContent(String str, String str2, String str3) {
        Log.d(TAG, "onViewContent: contentId=" + valueOrEmpty(str3));
        ActionUtils.onViewContent(str, str2, str3);
    }

    private static ChannelType toChannelType(int i) {
        switch (i) {
            case 1:
                return ChannelType.CHANNEL_NATURAL;
            case 2:
                return ChannelType.CHANNEL_TENCENT;
            case 3:
                return ChannelType.CHANNEL_BYTEDANCE;
            case 4:
                return ChannelType.CHANNEL_KUAISHOU;
            case 5:
                return ChannelType.CHANNEL_ALIBABA;
            case 6:
                return ChannelType.CHANNEL_BAIDU;
            case 7:
                return ChannelType.CHANNEL_OTHERS;
            default:
                return ChannelType.CHANNEL_UNKNOWN;
        }
    }
}
