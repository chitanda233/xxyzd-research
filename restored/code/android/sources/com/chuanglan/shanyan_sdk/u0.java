package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.content.SharedPreferences;

/* JADX INFO: loaded from: classes2.dex */
public class u0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile u0 f2015a;
    private static SharedPreferences b;
    private static SharedPreferences.Editor c;
    private static Context d;

    private u0() {
    }

    public static u0 a(Context context) {
        if (f2015a == null) {
            synchronized (u0.class) {
                if (f2015a == null) {
                    d = context;
                    f2015a = new u0();
                    SharedPreferences sharedPreferences = context.getSharedPreferences("cl_jm_file", 0);
                    b = sharedPreferences;
                    c = sharedPreferences.edit();
                }
            }
        }
        return f2015a;
    }

    SharedPreferences b() {
        SharedPreferences sharedPreferences = b;
        return sharedPreferences == null ? d.getSharedPreferences("cl_jm_file", 0) : sharedPreferences;
    }

    SharedPreferences.Editor a() {
        SharedPreferences.Editor editor = c;
        return editor == null ? b.edit() : editor;
    }
}
