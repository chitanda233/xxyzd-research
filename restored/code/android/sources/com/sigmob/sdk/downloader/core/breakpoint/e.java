package com.sigmob.sdk.downloader.core.breakpoint;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.SparseArray;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class e extends SQLiteOpenHelper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static final String f3383a = "taskFileDirty";
    private static final String b = "sig_breakpoint.db";
    private static final int c = 3;
    private static final String d = "FileDownloadResponseFilename";
    private static final String e = "breakpoint";
    private static final String f = "block";

    private interface a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final String f3384a = "CREATE TABLE IF NOT EXISTS breakpoint( id INTEGER PRIMARY KEY, url VARCHAR NOT NULL, etag VARCHAR, parent_path VARCHAR NOT NULL, filename VARCHAR, task_only_parent_path TINYINT(1) DEFAULT 0, chunked TINYINT(1) DEFAULT 0)";
        public static final String b = "CREATE TABLE IF NOT EXISTS block( id INTEGER PRIMARY KEY AUTOINCREMENT, breakpoint_id INTEGER, block_index INTEGER, start_offset INTEGER, content_length INTEGER, current_offset INTEGER)";
        public static final String c = "CREATE TABLE IF NOT EXISTS FileDownloadResponseFilename( url VARCHAR NOT NULL PRIMARY KEY, filename VARCHAR NOT NULL)";
        public static final String d = "CREATE TABLE IF NOT EXISTS taskFileDirty( id INTEGER PRIMARY KEY)";
    }

    private interface b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final String f3385a = "CREATE TABLE IF NOT EXISTS FileDownloadResponseFilename( url VARCHAR NOT NULL PRIMARY KEY, filename VARCHAR NOT NULL)";
        public static final String b = "CREATE TABLE IF NOT EXISTS taskFileDirty( id INTEGER PRIMARY KEY)";
    }

    private interface c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final String f3386a = "SELECT * FROM taskFileDirty";
        public static final String b = "SELECT * FROM breakpoint";
        public static final String c = "SELECT * FROM block";
        public static final String d = "SELECT * FROM FileDownloadResponseFilename";
        public static final String e = "SELECT filename FROM FileDownloadResponseFilename WHERE url = ?";
        public static final String f = "SELECT id FROM breakpoint WHERE id = ? LIMIT 1";
    }

    public e(Context context) {
        super(context, b, (SQLiteDatabase.CursorFactory) null, 3);
    }

    private static ContentValues a(int breakpointId, int index, com.sigmob.sdk.downloader.core.breakpoint.a info) {
        ContentValues contentValues = new ContentValues();
        contentValues.put(f.h, Integer.valueOf(breakpointId));
        contentValues.put(f.i, Integer.valueOf(index));
        contentValues.put(f.j, Long.valueOf(info.b()));
        contentValues.put(f.k, Long.valueOf(info.d()));
        contentValues.put(f.l, Long.valueOf(info.a()));
        return contentValues;
    }

    private static ContentValues c(com.sigmob.sdk.downloader.core.breakpoint.c cVar) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("id", Integer.valueOf(cVar.f3381a));
        contentValues.put("url", cVar.l());
        contentValues.put(f.c, cVar.k());
        contentValues.put(f.d, cVar.b.getAbsolutePath());
        contentValues.put(f.e, cVar.m());
        contentValues.put(f.f, Integer.valueOf(cVar.d() ? 1 : 0));
        contentValues.put("chunked", Integer.valueOf(cVar.b() ? 1 : 0));
        return contentValues;
    }

    public List<Integer> a() {
        ArrayList arrayList = new ArrayList();
        Cursor cursorRawQuery = getWritableDatabase().rawQuery(c.f3386a, null);
        while (cursorRawQuery.moveToNext()) {
            try {
                arrayList.add(Integer.valueOf(cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("id"))));
            } catch (Throwable th) {
                if (cursorRawQuery != null) {
                    try {
                        cursorRawQuery.close();
                    } catch (Throwable th2) {
                        th.addSuppressed(th2);
                    }
                }
                throw th;
            }
        }
        if (cursorRawQuery != null) {
            cursorRawQuery.close();
        }
        return arrayList;
    }

    public void a(int id) {
        SQLiteDatabase writableDatabase = getWritableDatabase();
        ContentValues contentValues = new ContentValues(1);
        contentValues.put("id", Integer.valueOf(id));
        writableDatabase.insert(f3383a, null, contentValues);
    }

    public void a(com.sigmob.sdk.downloader.core.breakpoint.c info) throws IOException {
        int iG = info.g();
        SQLiteDatabase writableDatabase = getWritableDatabase();
        for (int i = 0; i < iG; i++) {
            com.sigmob.sdk.downloader.core.breakpoint.a aVarB = info.b(i);
            if (writableDatabase.insert(f, null, a(info.f3381a, i, aVarB)) == -1) {
                throw new com.sigmob.sdk.downloader.core.exception.h("insert block " + aVarB + " failed!");
            }
        }
        if (writableDatabase.insert(e, null, c(info)) == -1) {
            throw new com.sigmob.sdk.downloader.core.exception.h("insert info " + info + " failed!");
        }
    }

    public void a(com.sigmob.sdk.downloader.core.breakpoint.c info, int blockIndex, long newCurrentOffset) {
        ContentValues contentValues = new ContentValues();
        contentValues.put(f.l, Long.valueOf(newCurrentOffset));
        getWritableDatabase().update(f, contentValues, "breakpoint_id = ? AND block_index = ?", new String[]{Integer.toString(info.f3381a), Integer.toString(blockIndex)});
    }

    public void a(String url, String filename) {
        SQLiteDatabase writableDatabase = getWritableDatabase();
        ContentValues contentValues = new ContentValues(2);
        contentValues.put("url", url);
        contentValues.put(f.e, filename);
        synchronized (url.intern()) {
            Cursor cursor = null;
            try {
                try {
                    Cursor cursorRawQuery = writableDatabase.rawQuery(c.e, new String[]{url});
                    try {
                        if (!cursorRawQuery.moveToFirst()) {
                            writableDatabase.insert(d, null, contentValues);
                        } else if (!filename.equals(cursorRawQuery.getString(cursorRawQuery.getColumnIndex(f.e)))) {
                            writableDatabase.replace(d, null, contentValues);
                        }
                        if (cursorRawQuery != null) {
                            cursorRawQuery.close();
                        }
                    } catch (Throwable th) {
                        th = th;
                        cursor = cursorRawQuery;
                        if (cursor != null) {
                            cursor.close();
                        }
                        throw th;
                    }
                } catch (Throwable th2) {
                    th = th2;
                }
            } catch (Throwable th3) {
                throw th3;
            }
        }
    }

    public SparseArray<com.sigmob.sdk.downloader.core.breakpoint.c> b() throws Throwable {
        Cursor cursor;
        SQLiteDatabase writableDatabase = getWritableDatabase();
        ArrayList arrayList = new ArrayList();
        ArrayList arrayList2 = new ArrayList();
        Cursor cursorRawQuery = null;
        try {
            Cursor cursorRawQuery2 = writableDatabase.rawQuery(c.b, null);
            while (cursorRawQuery2.moveToNext()) {
                try {
                    arrayList.add(new d(cursorRawQuery2));
                } catch (Throwable th) {
                    th = th;
                    cursor = cursorRawQuery;
                    cursorRawQuery = cursorRawQuery2;
                    if (cursorRawQuery != null) {
                        cursorRawQuery.close();
                    }
                    if (cursor != null) {
                        cursor.close();
                    }
                    throw th;
                }
            }
            cursorRawQuery = writableDatabase.rawQuery(c.c, null);
            while (cursorRawQuery.moveToNext()) {
                arrayList2.add(new com.sigmob.sdk.downloader.core.breakpoint.b(cursorRawQuery));
            }
            if (cursorRawQuery2 != null) {
                cursorRawQuery2.close();
            }
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
            SparseArray<com.sigmob.sdk.downloader.core.breakpoint.c> sparseArray = new SparseArray<>();
            Iterator it = arrayList.iterator();
            while (it.hasNext()) {
                com.sigmob.sdk.downloader.core.breakpoint.c cVarH = ((d) it.next()).h();
                Iterator it2 = arrayList2.iterator();
                while (it2.hasNext()) {
                    com.sigmob.sdk.downloader.core.breakpoint.b bVar = (com.sigmob.sdk.downloader.core.breakpoint.b) it2.next();
                    if (bVar.a() == cVarH.f3381a) {
                        cVarH.a(bVar.e());
                        it2.remove();
                    }
                }
                sparseArray.put(cVarH.f3381a, cVarH);
            }
            return sparseArray;
        } catch (Throwable th2) {
            th = th2;
            cursor = null;
        }
    }

    public void b(int id) {
        getWritableDatabase().delete(f3383a, "id = ?", new String[]{String.valueOf(id)});
    }

    public void b(com.sigmob.sdk.downloader.core.breakpoint.c info) throws IOException {
        SQLiteDatabase writableDatabase = getWritableDatabase();
        writableDatabase.beginTransaction();
        try {
            Cursor cursorRawQuery = getWritableDatabase().rawQuery(c.f, new String[]{Integer.toString(info.f3381a)});
            try {
                if (!cursorRawQuery.moveToNext()) {
                    if (cursorRawQuery != null) {
                        cursorRawQuery.close();
                    }
                    writableDatabase.endTransaction();
                    return;
                } else {
                    c(info.f3381a);
                    a(info);
                    writableDatabase.setTransactionSuccessful();
                    if (cursorRawQuery != null) {
                        cursorRawQuery.close();
                    }
                    writableDatabase.endTransaction();
                    return;
                }
            } catch (Throwable th) {
                if (cursorRawQuery != null) {
                    try {
                        cursorRawQuery.close();
                    } catch (Throwable th2) {
                        th.addSuppressed(th2);
                    }
                }
                throw th;
            }
        } catch (Throwable th3) {
            writableDatabase.endTransaction();
            throw th3;
        }
        writableDatabase.endTransaction();
        throw th3;
    }

    public HashMap<String, String> c() {
        SQLiteDatabase writableDatabase = getWritableDatabase();
        HashMap<String, String> map = new HashMap<>();
        Cursor cursorRawQuery = null;
        try {
            cursorRawQuery = writableDatabase.rawQuery(c.d, null);
            while (cursorRawQuery.moveToNext()) {
                int columnIndex = cursorRawQuery.getColumnIndex("url");
                String string = "";
                String string2 = columnIndex >= 0 ? cursorRawQuery.getString(columnIndex) : "";
                int columnIndex2 = cursorRawQuery.getColumnIndex(f.e);
                if (columnIndex2 >= 0) {
                    string = cursorRawQuery.getString(columnIndex2);
                }
                map.put(string2, string);
            }
            return map;
        } finally {
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
        }
    }

    public void c(int id) {
        getWritableDatabase().delete(e, "id = ?", new String[]{String.valueOf(id)});
        d(id);
    }

    public void d(int breakpointId) {
        getWritableDatabase().delete(f, "breakpoint_id = ?", new String[]{String.valueOf(breakpointId)});
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(a.f3384a);
        db.execSQL(a.b);
        db.execSQL("CREATE TABLE IF NOT EXISTS FileDownloadResponseFilename( url VARCHAR NOT NULL PRIMARY KEY, filename VARCHAR NOT NULL)");
        db.execSQL("CREATE TABLE IF NOT EXISTS taskFileDirty( id INTEGER PRIMARY KEY)");
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onDowngrade(SQLiteDatabase db, int oldVersion, int newVersion) {
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onOpen(SQLiteDatabase db) {
        super.onOpen(db);
        setWriteAheadLoggingEnabled(true);
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        if (oldVersion == 1 && newVersion == 2) {
            db.execSQL("CREATE TABLE IF NOT EXISTS FileDownloadResponseFilename( url VARCHAR NOT NULL PRIMARY KEY, filename VARCHAR NOT NULL)");
        }
        if (oldVersion <= 2) {
            db.execSQL("CREATE TABLE IF NOT EXISTS taskFileDirty( id INTEGER PRIMARY KEY)");
        }
    }
}
