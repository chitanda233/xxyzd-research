package com.kwad.framework.filedownloader.b;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteFullException;
import android.text.TextUtils;
import android.util.SparseArray;
import com.kwad.framework.filedownloader.f.f;
import java.io.Closeable;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class d implements com.kwad.framework.filedownloader.b.a {
    private static boolean aAH = false;
    private final e aAI = new e(com.kwad.framework.filedownloader.f.c.DJ());
    private SQLiteDatabase aAJ;

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cr(int i) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cw(int i) {
    }

    /* JADX WARN: Not initialized variable reg: 1, insn: 0x0048: MOVE (r0 I:??[OBJECT, ARRAY]) = (r1 I:??[OBJECT, ARRAY]), block:B:24:0x0048 */
    @Override // com.kwad.framework.filedownloader.b.a
    public final com.kwad.framework.filedownloader.d.c cs(int i) throws Throwable {
        Cursor cursorRawQuery;
        Closeable closeable;
        Closeable closeable2 = null;
        try {
            try {
                cursorRawQuery = Cf().rawQuery(f.c("SELECT * FROM %s WHERE %s = ?", "ksad_file_download", "_id"), new String[]{Integer.toString(i)});
                try {
                    if (cursorRawQuery.moveToNext()) {
                        com.kwad.framework.filedownloader.d.c cVarD = d(cursorRawQuery);
                        com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
                        return cVarD;
                    }
                } catch (SQLiteException e) {
                    e = e;
                    a(i, e);
                } catch (Exception e2) {
                    e = e2;
                    printStackTrace(e);
                }
            } catch (Throwable th) {
                th = th;
                closeable2 = closeable;
                com.kwad.sdk.crash.utils.b.closeQuietly(closeable2);
                throw th;
            }
        } catch (SQLiteException e3) {
            e = e3;
            cursorRawQuery = null;
        } catch (Exception e4) {
            e = e4;
            cursorRawQuery = null;
        } catch (Throwable th2) {
            th = th2;
            com.kwad.sdk.crash.utils.b.closeQuietly(closeable2);
            throw th;
        }
        com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
        return null;
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final List<com.kwad.framework.filedownloader.d.a> ct(int i) {
        ArrayList arrayList = new ArrayList();
        Cursor cursorRawQuery = null;
        try {
            try {
                cursorRawQuery = Cf().rawQuery(f.c("SELECT * FROM %s WHERE %s = ?", "ksad_file_download_connection", "id"), new String[]{Integer.toString(i)});
                while (cursorRawQuery.moveToNext()) {
                    com.kwad.framework.filedownloader.d.a aVar = new com.kwad.framework.filedownloader.d.a();
                    aVar.setId(i);
                    aVar.setIndex(cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("connectionIndex")));
                    aVar.setStartOffset(cursorRawQuery.getLong(cursorRawQuery.getColumnIndex("startOffset")));
                    aVar.aa(cursorRawQuery.getLong(cursorRawQuery.getColumnIndex("currentOffset")));
                    aVar.ab(cursorRawQuery.getLong(cursorRawQuery.getColumnIndex("endOffset")));
                    arrayList.add(aVar);
                }
            } catch (SQLiteException e) {
                a(i, e);
            } catch (Exception e2) {
                printStackTrace(e2);
            }
            com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
            return arrayList;
        } catch (Throwable th) {
            com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
            throw th;
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cu(int i) {
        try {
            Cf().execSQL("DELETE FROM ksad_file_download_connection WHERE id = " + i);
        } catch (SQLiteException e) {
            printStackTrace(e);
        } catch (Exception e2) {
            printStackTrace(e2);
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(com.kwad.framework.filedownloader.d.a aVar) {
        if (aVar != null) {
            try {
                Cf().insert("ksad_file_download_connection", null, aVar.Dh());
            } catch (SQLiteException e) {
                a(aVar.getId(), e);
            } catch (Exception e2) {
                printStackTrace(e2);
            }
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, int i2, long j) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("currentOffset", Long.valueOf(j));
        try {
            Cf().update("ksad_file_download_connection", contentValues, "id = ? AND connectionIndex = ?", new String[]{Integer.toString(i), Integer.toString(i2)});
        } catch (SQLiteException e) {
            a(i, e);
        } catch (Exception e2) {
            printStackTrace(e2);
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void w(int i, int i2) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("connectionCount", Integer.valueOf(i2));
        try {
            Cf().update("ksad_file_download", contentValues, "_id = ? ", new String[]{Integer.toString(i)});
        } catch (SQLiteException e) {
            a(i, e);
        } catch (Exception e2) {
            printStackTrace(e2);
        }
    }

    private void d(com.kwad.framework.filedownloader.d.c cVar) {
        try {
            Cf().insert("ksad_file_download", null, cVar.Dh());
        } catch (SQLiteException e) {
            cVar.cf(e.toString());
            cVar.d((byte) -1);
            a(cVar.getId(), e);
        } catch (Exception e2) {
            printStackTrace(e2);
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void b(com.kwad.framework.filedownloader.d.c cVar) {
        if (cVar == null) {
            com.kwad.framework.filedownloader.f.d.d(this, "update but model == null!", new Object[0]);
            return;
        }
        if (cs(cVar.getId()) != null) {
            try {
                Cf().update("ksad_file_download", cVar.Dh(), "_id = ? ", new String[]{String.valueOf(cVar.getId())});
                return;
            } catch (SQLiteException e) {
                cVar.cf(e.toString());
                cVar.d((byte) -1);
                a(cVar.getId(), e);
                return;
            } catch (Exception e2) {
                printStackTrace(e2);
                return;
            }
        }
        d(cVar);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final boolean cv(int i) {
        try {
            return Cf().delete("ksad_file_download", "_id = ?", new String[]{String.valueOf(i)}) != 0;
        } catch (SQLiteException e) {
            printStackTrace(e);
            return false;
        } catch (Exception e2) {
            printStackTrace(e2);
            return false;
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void clear() {
        try {
            Cf().delete("ksad_file_download", null, null);
        } catch (SQLiteException e) {
            a(e);
        }
        try {
            Cf().delete("ksad_file_download_connection", null, null);
        } catch (SQLiteException e2) {
            a(e2);
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, String str, long j, long j2, int i2) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("sofar", Long.valueOf(j));
        contentValues.put("total", Long.valueOf(j2));
        contentValues.put(com.sigmob.sdk.downloader.core.breakpoint.f.c, str);
        contentValues.put("connectionCount", Integer.valueOf(i2));
        a(i, contentValues);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, long j, String str, String str2) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("status", (Byte) (byte) 2);
        contentValues.put("total", Long.valueOf(j));
        contentValues.put(com.sigmob.sdk.downloader.core.breakpoint.f.c, str);
        contentValues.put(com.sigmob.sdk.downloader.core.breakpoint.f.e, str2);
        a(i, contentValues);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void b(int i, long j) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("status", (Byte) (byte) 3);
        contentValues.put("sofar", Long.valueOf(j));
        a(i, contentValues);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, Throwable th, long j) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("errMsg", th.toString());
        contentValues.put("status", (Byte) (byte) -1);
        contentValues.put("sofar", Long.valueOf(j));
        a(i, contentValues);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, Throwable th) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("errMsg", th.toString());
        contentValues.put("status", (Byte) (byte) 5);
        a(i, contentValues);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void c(int i, long j) {
        cv(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void d(int i, long j) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("status", (Byte) (byte) -2);
        contentValues.put("sofar", Long.valueOf(j));
        a(i, contentValues);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final com.kwad.framework.filedownloader.b.a.InterfaceC0482a Cd() {
        return new a(null, null);
    }

    public final com.kwad.framework.filedownloader.b.a.InterfaceC0482a a(SparseArray<com.kwad.framework.filedownloader.d.c> sparseArray, SparseArray<List<com.kwad.framework.filedownloader.d.a>> sparseArray2) {
        return new a(sparseArray, sparseArray2);
    }

    private void a(int i, ContentValues contentValues) {
        try {
            Cf().update("ksad_file_download", contentValues, "_id = ? ", new String[]{String.valueOf(i)});
        } catch (SQLiteException e) {
            a(i, e);
        } catch (Exception e2) {
            printStackTrace(e2);
        }
    }

    public class a implements com.kwad.framework.filedownloader.b.a.InterfaceC0482a {
        private final SparseArray<com.kwad.framework.filedownloader.d.c> aAK = new SparseArray<>();
        private b aAL;
        private final SparseArray<com.kwad.framework.filedownloader.d.c> aAx;
        private final SparseArray<List<com.kwad.framework.filedownloader.d.a>> aAy;

        a(SparseArray<com.kwad.framework.filedownloader.d.c> sparseArray, SparseArray<List<com.kwad.framework.filedownloader.d.a>> sparseArray2) {
            this.aAx = sparseArray;
            this.aAy = sparseArray2;
        }

        @Override // java.lang.Iterable
        public final Iterator<com.kwad.framework.filedownloader.d.c> iterator() {
            b bVar = d.this.new b();
            this.aAL = bVar;
            return bVar;
        }

        @Override // com.kwad.framework.filedownloader.b.a.InterfaceC0482a
        public final void Ce() {
            b bVar = this.aAL;
            if (bVar != null) {
                bVar.Ce();
            }
            try {
                SQLiteDatabase sQLiteDatabaseCf = d.this.Cf();
                if (sQLiteDatabaseCf == null) {
                    return;
                }
                int size = this.aAK.size();
                try {
                    if (size < 0) {
                        return;
                    }
                    try {
                        sQLiteDatabaseCf.beginTransaction();
                        for (int i = 0; i < size; i++) {
                            int iKeyAt = this.aAK.keyAt(i);
                            com.kwad.framework.filedownloader.d.c cVar = this.aAK.get(iKeyAt);
                            sQLiteDatabaseCf.delete("ksad_file_download", "_id = ?", new String[]{String.valueOf(iKeyAt)});
                            sQLiteDatabaseCf.insert("ksad_file_download", null, cVar.Dh());
                            if (cVar.Dm() > 1) {
                                List<com.kwad.framework.filedownloader.d.a> listCt = d.this.ct(iKeyAt);
                                if (listCt.size() > 0) {
                                    sQLiteDatabaseCf.delete("ksad_file_download_connection", "id = ?", new String[]{String.valueOf(iKeyAt)});
                                    for (com.kwad.framework.filedownloader.d.a aVar : listCt) {
                                        aVar.setId(cVar.getId());
                                        sQLiteDatabaseCf.insert("ksad_file_download_connection", null, aVar.Dh());
                                    }
                                }
                            }
                        }
                        SparseArray<com.kwad.framework.filedownloader.d.c> sparseArray = this.aAx;
                        if (sparseArray != null && this.aAy != null) {
                            synchronized (sparseArray) {
                                int size2 = this.aAx.size();
                                for (int i2 = 0; i2 < size2; i2++) {
                                    int id = this.aAx.valueAt(i2).getId();
                                    List<com.kwad.framework.filedownloader.d.a> listCt2 = d.this.ct(id);
                                    if (listCt2 != null && listCt2.size() > 0) {
                                        synchronized (this.aAy) {
                                            this.aAy.put(id, listCt2);
                                        }
                                    }
                                }
                            }
                        }
                        sQLiteDatabaseCf.setTransactionSuccessful();
                        if (sQLiteDatabaseCf != null) {
                            try {
                                sQLiteDatabaseCf.endTransaction();
                            } catch (Exception e) {
                                d.printStackTrace(e);
                            }
                        }
                    } catch (SQLiteException e2) {
                        d.this.a(e2);
                        if (sQLiteDatabaseCf != null) {
                            try {
                                sQLiteDatabaseCf.endTransaction();
                            } catch (Exception e3) {
                                d.printStackTrace(e3);
                            }
                        }
                    } catch (Exception e4) {
                        d.printStackTrace(e4);
                        if (sQLiteDatabaseCf != null) {
                            try {
                                sQLiteDatabaseCf.endTransaction();
                            } catch (Exception e5) {
                                d.printStackTrace(e5);
                            }
                        }
                    }
                } catch (Throwable th) {
                    if (sQLiteDatabaseCf != null) {
                        try {
                            sQLiteDatabaseCf.endTransaction();
                        } catch (Exception e6) {
                            d.printStackTrace(e6);
                        }
                    }
                    throw th;
                }
            } catch (Throwable unused) {
            }
        }

        @Override // com.kwad.framework.filedownloader.b.a.InterfaceC0482a
        public final void c(com.kwad.framework.filedownloader.d.c cVar) {
            SparseArray<com.kwad.framework.filedownloader.d.c> sparseArray = this.aAx;
            if (sparseArray != null) {
                synchronized (sparseArray) {
                    this.aAx.put(cVar.getId(), cVar);
                }
            }
        }

        @Override // com.kwad.framework.filedownloader.b.a.InterfaceC0482a
        public final void a(int i, com.kwad.framework.filedownloader.d.c cVar) {
            this.aAK.put(i, cVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public SQLiteDatabase Cf() {
        if (this.aAJ == null) {
            this.aAJ = this.aAI.getWritableDatabase();
        }
        return this.aAJ;
    }

    class b implements Iterator<com.kwad.framework.filedownloader.d.c> {
        private Cursor aAN;
        private final List<Integer> aAO = new ArrayList();
        private int aAP;

        b() {
            try {
                this.aAN = d.this.Cf().query("ksad_file_download", null, null, null, null, null, null);
            } catch (SQLiteException e) {
                d.this.a(e);
            } catch (Exception e2) {
                d.printStackTrace(e2);
            }
        }

        @Override // java.util.Iterator
        public final boolean hasNext() {
            try {
                Cursor cursor = this.aAN;
                if (cursor != null) {
                    return cursor.moveToNext();
                }
                return false;
            } catch (Throwable th) {
                d.printStackTrace(th);
                return false;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        @Override // java.util.Iterator
        /* JADX INFO: renamed from: Cg, reason: merged with bridge method [inline-methods] */
        public com.kwad.framework.filedownloader.d.c next() {
            com.kwad.framework.filedownloader.d.c cVarD = d.d(this.aAN);
            this.aAP = cVarD.getId();
            return cVarD;
        }

        @Override // java.util.Iterator
        public final void remove() {
            this.aAO.add(Integer.valueOf(this.aAP));
        }

        final void Ce() {
            Cursor cursor = this.aAN;
            if (cursor == null) {
                return;
            }
            cursor.close();
            if (this.aAO.isEmpty()) {
                return;
            }
            String strJoin = TextUtils.join(", ", this.aAO);
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "delete %s", strJoin);
            }
            try {
                SQLiteDatabase sQLiteDatabaseCf = d.this.Cf();
                sQLiteDatabaseCf.execSQL(f.c("DELETE FROM %s WHERE %s IN (%s);", "ksad_file_download", "_id", strJoin));
                sQLiteDatabaseCf.execSQL(f.c("DELETE FROM %s WHERE %s IN (%s);", "ksad_file_download_connection", "id", strJoin));
            } catch (SQLiteException e) {
                d.this.a(e);
            } catch (Exception e2) {
                d.printStackTrace(e2);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static com.kwad.framework.filedownloader.d.c d(Cursor cursor) {
        com.kwad.framework.filedownloader.d.c cVar = new com.kwad.framework.filedownloader.d.c();
        if (cursor == null) {
            return cVar;
        }
        cVar.setId(cursor.getInt(cursor.getColumnIndex("_id")));
        cVar.setUrl(cursor.getString(cursor.getColumnIndex("url")));
        cVar.d(cursor.getString(cursor.getColumnIndex("path")), cursor.getShort(cursor.getColumnIndex("pathAsDirectory")) == 1);
        cVar.d((byte) cursor.getShort(cursor.getColumnIndex("status")));
        cVar.ac(cursor.getLong(cursor.getColumnIndex("sofar")));
        cVar.ae(cursor.getLong(cursor.getColumnIndex("total")));
        cVar.cf(cursor.getString(cursor.getColumnIndex("errMsg")));
        cVar.ce(cursor.getString(cursor.getColumnIndex(com.sigmob.sdk.downloader.core.breakpoint.f.c)));
        cVar.cg(cursor.getString(cursor.getColumnIndex(com.sigmob.sdk.downloader.core.breakpoint.f.e)));
        cVar.cL(cursor.getInt(cursor.getColumnIndex("connectionCount")));
        return cVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(SQLiteException sQLiteException) {
        a(-1, sQLiteException);
    }

    private void a(int i, SQLiteException sQLiteException) {
        if (sQLiteException instanceof SQLiteFullException) {
            if (i != -1) {
                cv(i);
                cu(i);
            }
            o(sQLiteException);
            aAH = true;
            return;
        }
        printStackTrace(sQLiteException);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void printStackTrace(Throwable th) {
        o(th);
    }

    private static void o(Throwable th) {
        if (th != null) {
            th.printStackTrace();
        }
    }
}
