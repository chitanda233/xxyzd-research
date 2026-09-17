package com.sigmob.sdk.videocache.sourcestorage;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import com.sigmob.sdk.videocache.n;
import com.sigmob.sdk.videocache.u;

/* JADX INFO: loaded from: classes4.dex */
class a extends SQLiteOpenHelper implements c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3680a = "SourceInfo";
    private static final String c = "url";
    private static final String g = "CREATE TABLE SourceInfo (_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,url TEXT NOT NULL,mime TEXT,length INTEGER);";
    private static final String b = "_id";
    private static final String d = "length";
    private static final String e = "mime";
    private static final String[] f = {b, "url", d, e};

    a(Context context) {
        super(context, "AndroidVideoCache.db", (SQLiteDatabase.CursorFactory) null, 1);
        n.a(context);
    }

    private ContentValues a(u sourceInfo) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("url", sourceInfo.f3681a);
        contentValues.put(d, Long.valueOf(sourceInfo.b));
        contentValues.put(e, sourceInfo.c);
        return contentValues;
    }

    private u a(Cursor cursor) {
        return new u(cursor.getString(cursor.getColumnIndexOrThrow("url")), cursor.getLong(cursor.getColumnIndexOrThrow(d)), cursor.getString(cursor.getColumnIndexOrThrow(e)));
    }

    @Override // com.sigmob.sdk.videocache.sourcestorage.c
    public u a(String url) throws Throwable {
        Throwable th;
        Cursor cursorQuery;
        n.a(url);
        u uVarA = null;
        try {
            cursorQuery = getReadableDatabase().query(f3680a, f, "url=?", new String[]{url}, null, null, null);
            if (cursorQuery != null) {
                try {
                    if (cursorQuery.moveToFirst()) {
                        uVarA = a(cursorQuery);
                    }
                } catch (Throwable th2) {
                    th = th2;
                    if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                    throw th;
                }
            }
            if (cursorQuery != null) {
                cursorQuery.close();
            }
            return uVarA;
        } catch (Throwable th3) {
            th = th3;
            cursorQuery = null;
        }
    }

    @Override // com.sigmob.sdk.videocache.sourcestorage.c
    public void a() {
        close();
    }

    @Override // com.sigmob.sdk.videocache.sourcestorage.c
    public void a(String url, u sourceInfo) {
        n.a(url, sourceInfo);
        boolean z = a(url) != null;
        ContentValues contentValuesA = a(sourceInfo);
        if (z) {
            getWritableDatabase().update(f3680a, contentValuesA, "url=?", new String[]{url});
        } else {
            getWritableDatabase().insert(f3680a, null, contentValuesA);
        }
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onCreate(SQLiteDatabase db) {
        n.a(db);
        db.execSQL(g);
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        throw new IllegalStateException("Should not be called. There is no any migration");
    }
}
