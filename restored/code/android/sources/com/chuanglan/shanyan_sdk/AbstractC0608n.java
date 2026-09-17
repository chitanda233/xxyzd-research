package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import java.io.File;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.n, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
abstract class AbstractC0608n extends SQLiteOpenHelper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private File f1989a;

    AbstractC0608n(Context context, String str, SQLiteDatabase.CursorFactory cursorFactory, int i, boolean z) {
        super(context, str, cursorFactory, i);
        this.f1989a = z ? null : AbstractC0617w.a(AbstractC0617w.b(), str);
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public SQLiteDatabase getReadableDatabase() {
        File file = this.f1989a;
        SQLiteDatabase readableDatabase = file == null ? super.getReadableDatabase() : SQLiteDatabase.openOrCreateDatabase(file, (SQLiteDatabase.CursorFactory) null);
        onCreate(readableDatabase);
        return readableDatabase;
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public SQLiteDatabase getWritableDatabase() {
        File file = this.f1989a;
        SQLiteDatabase writableDatabase = file == null ? super.getWritableDatabase() : SQLiteDatabase.openOrCreateDatabase(file, (SQLiteDatabase.CursorFactory) null);
        onCreate(writableDatabase);
        return writableDatabase;
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onCreate(SQLiteDatabase sQLiteDatabase) {
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
    }
}
