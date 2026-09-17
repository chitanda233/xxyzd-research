package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.net.Uri;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes2.dex */
public abstract class d0 implements c0 {
    protected static boolean e = false;
    private static String f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected boolean f1966a = false;
    private String b;
    private String c;
    private String[] d;

    public d0(String str, String str2) {
        this.b = str;
        this.c = str2;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public boolean a(Context context) {
        if (this.f1966a) {
            return e;
        }
        if (context == null) {
            return false;
        }
        try {
            PackageManager packageManager = context.getPackageManager();
            e = (packageManager == null || packageManager.resolveContentProvider(this.b, 0) == null) ? false : true;
        } catch (Throwable unused) {
            e = false;
        }
        this.f1966a = true;
        return e;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public boolean b(Context context) {
        return true;
    }

    @Override // com.chuanglan.shanyan_sdk.c0
    public String c(Context context) {
        if (TextUtils.isEmpty(f)) {
            try {
                Cursor cursorQuery = context.getContentResolver().query(Uri.parse("content://" + this.b + "/" + this.c), null, null, this.d, null);
                if (cursorQuery != null) {
                    cursorQuery.moveToFirst();
                    f = cursorQuery.getString(cursorQuery.getColumnIndex("value"));
                }
            } catch (Throwable unused) {
                f = null;
            }
        }
        return f;
    }
}
