package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

/* JADX INFO: loaded from: classes2.dex */
public class J extends AbstractC0608n {
    private static volatile J b;

    private J(Context context) {
        super(context, "cl_jm_database.db", null, 2375, true);
    }

    public static J a(Context context) {
        if (b == null) {
            synchronized (J.class) {
                if (b == null) {
                    b = new J(context);
                }
            }
        }
        return b;
    }

    @Override // com.chuanglan.shanyan_sdk.AbstractC0608n, android.database.sqlite.SQLiteOpenHelper
    public /* bridge */ /* synthetic */ SQLiteDatabase getReadableDatabase() {
        return super.getReadableDatabase();
    }

    @Override // com.chuanglan.shanyan_sdk.AbstractC0608n, android.database.sqlite.SQLiteOpenHelper
    public /* bridge */ /* synthetic */ SQLiteDatabase getWritableDatabase() {
        return super.getWritableDatabase();
    }

    @Override // com.chuanglan.shanyan_sdk.AbstractC0608n, android.database.sqlite.SQLiteOpenHelper
    public void onCreate(SQLiteDatabase sQLiteDatabase) {
        super.onCreate(sQLiteDatabase);
        sQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS cl_jm_device(i4 text UNIQUE,i8 text,i1 text,i7 text,i9 text)");
        sQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS cl_jm_behavior(id INTEGER PRIMARY KEY AUTOINCREMENT,i4 text,bk text,bp text,bm text,b2 text,bc text,bh text,ba text,b7 text,bi text,b8 text,bg text,bj text,bb text,bl text,b5 INTEGER ,b1 INTEGER ,b4 text,be text,b3 text,b6 text,bd text,b9 INTEGER,bf text)");
    }

    @Override // com.chuanglan.shanyan_sdk.AbstractC0608n, android.database.sqlite.SQLiteOpenHelper
    public void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
        super.onUpgrade(sQLiteDatabase, i, i2);
    }
}
