package com.gorilla.base.service;

import android.content.Context;
import android.content.SharedPreferences;

/* JADX INFO: loaded from: classes3.dex */
public class SharePreferenceService {
    private final SharedPreferences sp;

    public SharePreferenceService(Context context) {
        this.sp = context.getSharedPreferences("gorilla", 0);
    }

    public void put(String str, String str2) {
        SharedPreferences sharedPreferences = this.sp;
        if (sharedPreferences != null) {
            SharedPreferences.Editor editorEdit = sharedPreferences.edit();
            editorEdit.putString(str, str2);
            editorEdit.apply();
        }
    }

    public String get(String str, String str2) {
        SharedPreferences sharedPreferences = this.sp;
        return sharedPreferences != null ? sharedPreferences.getString(str, str2) : str2;
    }

    public void put(String str, int i) {
        SharedPreferences sharedPreferences = this.sp;
        if (sharedPreferences != null) {
            SharedPreferences.Editor editorEdit = sharedPreferences.edit();
            editorEdit.putInt(str, i);
            editorEdit.apply();
        }
    }

    public int get(String str, int i) {
        SharedPreferences sharedPreferences = this.sp;
        return sharedPreferences != null ? sharedPreferences.getInt(str, i) : i;
    }

    public void put(String str, long j) {
        SharedPreferences sharedPreferences = this.sp;
        if (sharedPreferences != null) {
            SharedPreferences.Editor editorEdit = sharedPreferences.edit();
            editorEdit.putLong(str, j);
            editorEdit.apply();
        }
    }

    public long get(String str, long j) {
        SharedPreferences sharedPreferences = this.sp;
        return sharedPreferences != null ? sharedPreferences.getLong(str, j) : j;
    }

    public void put(String str, boolean z) {
        SharedPreferences sharedPreferences = this.sp;
        if (sharedPreferences != null) {
            SharedPreferences.Editor editorEdit = sharedPreferences.edit();
            editorEdit.putBoolean(str, z);
            editorEdit.apply();
        }
    }

    public boolean get(String str, boolean z) {
        SharedPreferences sharedPreferences = this.sp;
        return sharedPreferences != null ? sharedPreferences.getBoolean(str, z) : z;
    }
}
