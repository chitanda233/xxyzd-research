package com.chuanglan.shanyan_sdk;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
public class I {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private J f1943a;
    private long b;
    private boolean c;

    public I(Context context) {
        this.f1943a = J.a(context);
    }

    private synchronized void a(SQLiteDatabase sQLiteDatabase) {
        if (sQLiteDatabase != null) {
            try {
                sQLiteDatabase.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    private synchronized SQLiteDatabase d() {
        return this.f1943a.getWritableDatabase();
    }

    public long b() {
        return this.b;
    }

    /* JADX WARN: Code duplicated, block: B:33:0x003c A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public long c() throws Throwable {
        SQLiteDatabase sQLiteDatabaseD;
        Cursor cursorRawQuery = null;
        try {
            sQLiteDatabaseD = d();
            try {
                try {
                    cursorRawQuery = sQLiteDatabaseD.rawQuery("select count(*) from cl_jm_behavior", null);
                    cursorRawQuery.moveToFirst();
                    long j = cursorRawQuery.getLong(0);
                    try {
                        cursorRawQuery.close();
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                    a(sQLiteDatabaseD);
                    return j;
                } catch (Exception e2) {
                    e = e2;
                    e.printStackTrace();
                    if (cursorRawQuery != null) {
                        try {
                            cursorRawQuery.close();
                        } catch (Exception e3) {
                            e3.printStackTrace();
                        }
                    }
                    a(sQLiteDatabaseD);
                    return 0L;
                }
            } catch (Throwable th) {
                th = th;
                if (cursorRawQuery != null) {
                    try {
                        cursorRawQuery.close();
                    } catch (Exception e4) {
                        e4.printStackTrace();
                    }
                }
                a(sQLiteDatabaseD);
                throw th;
            }
        } catch (Exception e5) {
            e = e5;
            sQLiteDatabaseD = null;
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseD = null;
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
            a(sQLiteDatabaseD);
            throw th;
        }
    }

    public void a(C0620z c0620z) throws Throwable {
        SQLiteDatabase sQLiteDatabase = null;
        if (c0620z != null) {
            try {
                try {
                    SQLiteDatabase sQLiteDatabaseD = d();
                    try {
                        ContentValues contentValues = new ContentValues();
                        contentValues.put("i4", c0620z.f2037a);
                        contentValues.put("i8", c0620z.b);
                        contentValues.put("i1", c0620z.c);
                        contentValues.put("i7", c0620z.d);
                        contentValues.put("i9", c0620z.e);
                        sQLiteDatabaseD.insertWithOnConflict("cl_jm_device", null, contentValues, 5);
                        sQLiteDatabase = sQLiteDatabaseD;
                    } catch (Exception e) {
                        e = e;
                        sQLiteDatabase = sQLiteDatabaseD;
                        e.printStackTrace();
                    } catch (Throwable th) {
                        th = th;
                        sQLiteDatabase = sQLiteDatabaseD;
                        a(sQLiteDatabase);
                        throw th;
                    }
                } catch (Exception e2) {
                    e = e2;
                }
            } catch (Throwable th2) {
                th = th2;
            }
        }
        a(sQLiteDatabase);
    }

    public void a(C0619y c0619y, boolean z) throws Throwable {
        SQLiteDatabase sQLiteDatabase = null;
        if (c0619y != null) {
            try {
                try {
                    SQLiteDatabase sQLiteDatabaseD = d();
                    try {
                        this.c = true;
                        if (z) {
                            String str = c0619y.x;
                            long j = c0619y.p;
                            a(str, j, j, sQLiteDatabaseD);
                        }
                        if (this.c || !z) {
                            ContentValues contentValues = new ContentValues();
                            contentValues.put("i4", c0619y.f2036a);
                            contentValues.put("bk", c0619y.b);
                            contentValues.put("bp", Integer.valueOf(c0619y.c));
                            contentValues.put("bm", c0619y.d);
                            contentValues.put("b2", c0619y.e);
                            contentValues.put("bc", c0619y.f);
                            contentValues.put("bh", c0619y.g);
                            contentValues.put("ba", c0619y.h);
                            contentValues.put("b7", c0619y.i);
                            contentValues.put("bi", c0619y.j);
                            contentValues.put("b8", c0619y.k);
                            contentValues.put("bg", c0619y.l);
                            contentValues.put("bj", Integer.valueOf(c0619y.m));
                            contentValues.put("bb", Integer.valueOf(c0619y.n));
                            contentValues.put("bl", Long.valueOf(c0619y.o));
                            contentValues.put("b5", Long.valueOf(c0619y.p));
                            contentValues.put("b1", Long.valueOf(c0619y.q));
                            contentValues.put("b4", Integer.valueOf(c0619y.r));
                            contentValues.put("be", Integer.valueOf(c0619y.s));
                            contentValues.put("b3", c0619y.t);
                            contentValues.put("b6", Integer.valueOf(c0619y.u));
                            contentValues.put("bd", c0619y.v);
                            contentValues.put("b9", Integer.valueOf(c0619y.w));
                            contentValues.put("bf", c0619y.x);
                            sQLiteDatabaseD.insert("cl_jm_behavior", null, contentValues);
                        }
                        sQLiteDatabase = sQLiteDatabaseD;
                    } catch (Exception e) {
                        e = e;
                        sQLiteDatabase = sQLiteDatabaseD;
                        e.printStackTrace();
                    } catch (Throwable th) {
                        th = th;
                        sQLiteDatabase = sQLiteDatabaseD;
                        a(sQLiteDatabase);
                        throw th;
                    }
                } catch (Exception e2) {
                    e = e2;
                }
            } catch (Throwable th2) {
                th = th2;
            }
        }
        a(sQLiteDatabase);
    }

    /* JADX WARN: Code duplicated, block: B:47:0x0096 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public List a() throws Throwable {
        SQLiteDatabase sQLiteDatabaseD;
        Throwable th;
        Cursor cursorQuery;
        try {
            sQLiteDatabaseD = d();
            try {
                cursorQuery = sQLiteDatabaseD.query("cl_jm_device", null, null, null, null, null, "i4 ASC", null);
                try {
                    try {
                        ArrayList arrayList = new ArrayList();
                        while (cursorQuery.moveToNext()) {
                            C0620z c0620z = new C0620z();
                            c0620z.f2037a = cursorQuery.getString(cursorQuery.getColumnIndex("i4"));
                            c0620z.b = cursorQuery.getString(cursorQuery.getColumnIndex("i8"));
                            c0620z.c = cursorQuery.getString(cursorQuery.getColumnIndex("i1"));
                            c0620z.d = cursorQuery.getString(cursorQuery.getColumnIndex("i7"));
                            c0620z.e = cursorQuery.getString(cursorQuery.getColumnIndex("i9"));
                            arrayList.add(c0620z);
                        }
                        try {
                            cursorQuery.close();
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                        a(sQLiteDatabaseD);
                        return arrayList;
                    } catch (Exception e2) {
                        e = e2;
                        e.printStackTrace();
                        if (cursorQuery != null) {
                            try {
                                cursorQuery.close();
                            } catch (Exception e3) {
                                e3.printStackTrace();
                            }
                        }
                        a(sQLiteDatabaseD);
                        return null;
                    }
                } catch (Throwable th2) {
                    th = th2;
                    if (cursorQuery != null) {
                        try {
                            cursorQuery.close();
                        } catch (Exception e4) {
                            e4.printStackTrace();
                        }
                    }
                    a(sQLiteDatabaseD);
                    throw th;
                }
            } catch (Exception e5) {
                e = e5;
                cursorQuery = null;
            } catch (Throwable th3) {
                cursorQuery = null;
                th = th3;
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
                a(sQLiteDatabaseD);
                throw th;
            }
        } catch (Exception e6) {
            e = e6;
            cursorQuery = null;
            sQLiteDatabaseD = null;
        } catch (Throwable th4) {
            sQLiteDatabaseD = null;
            th = th4;
            cursorQuery = null;
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r13v0, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r13v2 */
    /* JADX WARN: Type inference failed for: r13v4, types: [android.database.Cursor] */
    /* JADX WARN: Type inference failed for: r13v9 */
    public List a(String str) throws Throwable {
        SQLiteDatabase sQLiteDatabaseD;
        Throwable th;
        Cursor cursorQuery;
        try {
            try {
                sQLiteDatabaseD = d();
                try {
                    cursorQuery = sQLiteDatabaseD.query("cl_jm_behavior", null, null, null, null, null, "id ASC", str);
                    try {
                        ArrayList arrayList = new ArrayList();
                        while (cursorQuery.moveToNext()) {
                            C0619y c0619y = new C0619y();
                            c0619y.f2036a = cursorQuery.getString(cursorQuery.getColumnIndex("i4"));
                            c0619y.b = cursorQuery.getString(cursorQuery.getColumnIndex("bk"));
                            c0619y.c = cursorQuery.getInt(cursorQuery.getColumnIndex("bp"));
                            c0619y.d = cursorQuery.getString(cursorQuery.getColumnIndex("bm"));
                            c0619y.e = cursorQuery.getString(cursorQuery.getColumnIndex("b2"));
                            c0619y.f = cursorQuery.getString(cursorQuery.getColumnIndex("bc"));
                            c0619y.g = cursorQuery.getString(cursorQuery.getColumnIndex("bh"));
                            c0619y.h = cursorQuery.getString(cursorQuery.getColumnIndex("ba"));
                            c0619y.i = cursorQuery.getString(cursorQuery.getColumnIndex("b7"));
                            c0619y.j = cursorQuery.getString(cursorQuery.getColumnIndex("bi"));
                            c0619y.k = cursorQuery.getString(cursorQuery.getColumnIndex("b8"));
                            c0619y.l = cursorQuery.getString(cursorQuery.getColumnIndex("bg"));
                            c0619y.m = cursorQuery.getInt(cursorQuery.getColumnIndex("bj"));
                            c0619y.n = cursorQuery.getInt(cursorQuery.getColumnIndex("bb"));
                            c0619y.o = cursorQuery.getLong(cursorQuery.getColumnIndex("bl"));
                            c0619y.p = cursorQuery.getLong(cursorQuery.getColumnIndex("b5"));
                            c0619y.q = cursorQuery.getLong(cursorQuery.getColumnIndex("b1"));
                            c0619y.r = cursorQuery.getInt(cursorQuery.getColumnIndex("b4"));
                            c0619y.s = cursorQuery.getInt(cursorQuery.getColumnIndex("be"));
                            c0619y.t = cursorQuery.getString(cursorQuery.getColumnIndex("b3"));
                            c0619y.u = cursorQuery.getInt(cursorQuery.getColumnIndex("b6"));
                            c0619y.v = cursorQuery.getString(cursorQuery.getColumnIndex("bd"));
                            c0619y.w = cursorQuery.getInt(cursorQuery.getColumnIndex("b9"));
                            c0619y.x = cursorQuery.getString(cursorQuery.getColumnIndex("bf"));
                            this.b = cursorQuery.getInt(cursorQuery.getColumnIndex("id"));
                            arrayList.add(c0619y);
                        }
                        try {
                            cursorQuery.close();
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                        a(sQLiteDatabaseD);
                        return arrayList;
                    } catch (Exception e2) {
                        e = e2;
                        e.printStackTrace();
                        if (cursorQuery != null) {
                            try {
                                cursorQuery.close();
                            } catch (Exception e3) {
                                e3.printStackTrace();
                            }
                        }
                        a(sQLiteDatabaseD);
                        return null;
                    }
                } catch (Exception e4) {
                    e = e4;
                    cursorQuery = null;
                } catch (Throwable th2) {
                    th = th2;
                    str = 0;
                    if (str != 0) {
                        try {
                            str.close();
                        } catch (Exception e5) {
                            e5.printStackTrace();
                        }
                    }
                    a(sQLiteDatabaseD);
                    throw th;
                }
            } catch (Throwable th3) {
                th = th3;
            }
        } catch (Exception e6) {
            e = e6;
            cursorQuery = null;
            sQLiteDatabaseD = null;
        } catch (Throwable th4) {
            sQLiteDatabaseD = null;
            th = th4;
            str = 0;
        }
    }

    /* JADX WARN: Code duplicated, block: B:42:0x0040 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public boolean a(int i) throws Throwable {
        SQLiteDatabase sQLiteDatabaseD;
        Cursor cursorRawQuery = null;
        try {
            sQLiteDatabaseD = d();
            try {
                try {
                    cursorRawQuery = sQLiteDatabaseD.rawQuery("select count(*) from cl_jm_behavior", null);
                    cursorRawQuery.moveToFirst();
                    boolean z = cursorRawQuery.getLong(0) > ((long) i);
                    try {
                        cursorRawQuery.close();
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                    a(sQLiteDatabaseD);
                    return z;
                } catch (Exception e2) {
                    e = e2;
                    e.printStackTrace();
                    if (cursorRawQuery != null) {
                        try {
                            cursorRawQuery.close();
                        } catch (Exception e3) {
                            e3.printStackTrace();
                        }
                    }
                    a(sQLiteDatabaseD);
                    return false;
                }
            } catch (Throwable th) {
                th = th;
                if (cursorRawQuery != null) {
                    try {
                        cursorRawQuery.close();
                    } catch (Exception e4) {
                        e4.printStackTrace();
                    }
                }
                a(sQLiteDatabaseD);
                throw th;
            }
        } catch (Exception e5) {
            e = e5;
            sQLiteDatabaseD = null;
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseD = null;
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
            a(sQLiteDatabaseD);
            throw th;
        }
    }

    private void a(String str, long j, long j2, SQLiteDatabase sQLiteDatabase) throws Throwable {
        Throwable th;
        int i;
        Cursor cursor = null;
        try {
            try {
                try {
                    ArrayList arrayList = new ArrayList();
                    Cursor cursorRawQuery = sQLiteDatabase.rawQuery("select * from cl_jm_behavior where bf = ?", new String[]{String.valueOf(str)});
                    try {
                        if (cursorRawQuery.moveToLast()) {
                            C0619y c0619y = new C0619y();
                            c0619y.f2036a = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("i4"));
                            c0619y.b = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bk"));
                            c0619y.c = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("bp"));
                            c0619y.d = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bm"));
                            c0619y.e = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("b2"));
                            c0619y.f = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bc"));
                            c0619y.g = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bh"));
                            c0619y.h = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("ba"));
                            c0619y.i = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("b7"));
                            c0619y.j = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bi"));
                            c0619y.k = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("b8"));
                            c0619y.l = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bg"));
                            c0619y.m = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("bj"));
                            c0619y.n = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("bb"));
                            c0619y.o = cursorRawQuery.getLong(cursorRawQuery.getColumnIndex("bl"));
                            c0619y.p = cursorRawQuery.getLong(cursorRawQuery.getColumnIndex("b5"));
                            c0619y.q = cursorRawQuery.getLong(cursorRawQuery.getColumnIndex("b1"));
                            c0619y.r = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("b4"));
                            c0619y.s = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("be"));
                            c0619y.t = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("b3"));
                            c0619y.u = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("b6"));
                            c0619y.v = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bd"));
                            c0619y.w = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("b9"));
                            c0619y.x = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("bf"));
                            arrayList.add(c0619y);
                            i = cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("id"));
                        } else {
                            i = 0;
                        }
                        if (arrayList.size() > 0) {
                            a((C0619y) arrayList.get(0), j, j2, i, sQLiteDatabase);
                            this.c = false;
                        } else {
                            this.c = true;
                        }
                        cursorRawQuery.close();
                    } catch (Exception e) {
                        e = e;
                        cursor = cursorRawQuery;
                        e.printStackTrace();
                        if (cursor == null) {
                        } else {
                            cursor.close();
                        }
                    } catch (Throwable th2) {
                        th = th2;
                        cursor = cursorRawQuery;
                        if (cursor != null) {
                            try {
                                cursor.close();
                                throw th;
                            } catch (Exception e2) {
                                e2.printStackTrace();
                                throw th;
                            }
                        }
                        throw th;
                    }
                } catch (Exception e3) {
                    e = e3;
                }
            } catch (Throwable th3) {
                th = th3;
            }
        } catch (Exception e4) {
            e4.printStackTrace();
        }
    }

    private void a(C0619y c0619y, long j, long j2, int i, SQLiteDatabase sQLiteDatabase) {
        try {
            ContentValues contentValues = new ContentValues();
            contentValues.put("b9", Integer.valueOf(c0619y.w + 1));
            contentValues.put("b5", Long.valueOf(c0619y.p + j));
            contentValues.put("b1", Long.valueOf(c0619y.q + j2));
            sQLiteDatabase.update("cl_jm_behavior", contentValues, "id=?", new String[]{"" + i});
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void a(long j) {
        SQLiteDatabase sQLiteDatabaseD = null;
        try {
            try {
                sQLiteDatabaseD = d();
                sQLiteDatabaseD.delete("cl_jm_behavior", "id <= ?", new String[]{String.valueOf(j)});
            } catch (Exception e) {
                e.printStackTrace();
            }
        } finally {
            a(sQLiteDatabaseD);
        }
    }
}
