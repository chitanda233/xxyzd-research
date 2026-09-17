package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.SharedPreferences;

/* JADX INFO: loaded from: classes4.dex */
public abstract class be {
    public static void b(Context context, String str, Long l) {
        try {
            SharedPreferences.Editor editorEdit = context.getSharedPreferences("cuAuthCacheName", 0).edit();
            editorEdit.putLong(str, l.longValue());
            editorEdit.commit();
        } catch (Exception e) {
            e.getMessage();
        }
    }

    public static Long c(Context context, String str) {
        long j = 0;
        try {
            j = context.getSharedPreferences("cuAuthCacheName", 0).getLong(str, 0L);
        } catch (Exception e) {
            e.getMessage();
        }
        return Long.valueOf(j);
    }

    public static void b(Context context, String str) {
        SharedPreferences sharedPreferences = context.getSharedPreferences("cuAuthCacheName", 0);
        SharedPreferences.Editor editorEdit = sharedPreferences.edit();
        for (String str2 : sharedPreferences.getAll().keySet()) {
            if (str2.startsWith(str)) {
                editorEdit.remove(str2);
            }
        }
        editorEdit.commit();
    }
}
