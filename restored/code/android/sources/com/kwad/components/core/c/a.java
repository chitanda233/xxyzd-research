package com.kwad.components.core.c;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteOpenHelper;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static volatile a OY;
    private final SQLiteDatabase OW;
    private ConcurrentHashMap<String, e> OX = new ConcurrentHashMap<>();

    public static a oF() {
        if (OY == null) {
            synchronized (a.class) {
                if (OY == null) {
                    try {
                        OY = new a(ServiceProvider.Um());
                    } catch (SQLiteException e) {
                        com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                        OY = null;
                    }
                }
            }
        }
        return OY;
    }

    private a(Context context) {
        this.OW = new C0418a(context).getWritableDatabase();
    }

    public final List<i> a(String str, long j, int i) throws Throwable {
        Cursor cursorRawQuery;
        Cursor cursor = null;
        try {
            cursorRawQuery = this.OW.rawQuery("select  * from ksad_ad_cache where posId=? order by createTime desc", new String[]{str});
            try {
                try {
                    List<i> listA = i.a(cursorRawQuery);
                    if (listA != null) {
                        StringBuilder sb = new StringBuilder("(posId = " + str + ") AND (");
                        ArrayList arrayList = new ArrayList();
                        int i2 = 0;
                        for (i iVar : listA) {
                            i2++;
                            if (i2 > i) {
                                sb.append(" creativeId = ");
                                sb.append(iVar.pb());
                                if (i2 == listA.size()) {
                                    sb.append(")");
                                } else {
                                    sb.append(" OR");
                                }
                            } else if (iVar.oZ() >= j) {
                                arrayList.add(iVar);
                            }
                        }
                        if (i2 > i) {
                            this.OW.delete("ksad_ad_cache", sb.toString(), new String[0]);
                        }
                        com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
                        return arrayList;
                    }
                    com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
                    return null;
                } catch (Exception e) {
                    e = e;
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                    com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
                    return null;
                }
            } catch (Throwable th) {
                th = th;
                cursor = cursorRawQuery;
            }
        } catch (Exception e2) {
            e = e2;
            cursorRawQuery = null;
        } catch (Throwable th2) {
            th = th2;
        }
        th = th;
        cursor = cursorRawQuery;
        com.kwad.sdk.crash.utils.b.closeQuietly(cursor);
        throw th;
    }

    public final void j(List<i> list) {
        b(list, "ksad_ad_cache");
    }

    public final void w(long j) {
        try {
            com.kwad.sdk.core.d.c.d("AdCacheDBManager", "deleteCachedAdByCreativeId result: " + this.OW.delete("ksad_ad_cache", "creativeId=?", new String[]{String.valueOf(j)}));
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    public final void oG() {
        try {
            this.OW.delete("ksad_ad_cache", "expireTime<?", new String[]{String.valueOf(System.currentTimeMillis() / 1000)});
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    public final e af(String str) throws Throwable {
        Cursor cursorRawQuery;
        e eVar;
        ConcurrentHashMap<String, e> concurrentHashMap = this.OX;
        if (concurrentHashMap != null && (eVar = concurrentHashMap.get(str)) != null) {
            com.kwad.sdk.core.d.c.d("AdCacheDBManager", "findCacheStrategyList from cache, posId: " + str);
            return eVar;
        }
        Cursor cursor = null;
        try {
            cursorRawQuery = this.OW.rawQuery("select  * from ksad_ad_cache_strategy where posId=?", new String[]{str});
            try {
                try {
                    List<e> listA = e.a(cursorRawQuery);
                    if (listA != null && listA.size() > 0) {
                        e eVar2 = listA.get(0);
                        this.OX.put(str, eVar2);
                        com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
                        return eVar2;
                    }
                } catch (Exception e) {
                    e = e;
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                }
            } catch (Throwable th) {
                th = th;
                cursor = cursorRawQuery;
                com.kwad.sdk.crash.utils.b.closeQuietly(cursor);
                throw th;
            }
        } catch (Exception e2) {
            e = e2;
            cursorRawQuery = null;
        } catch (Throwable th2) {
            th = th2;
            com.kwad.sdk.crash.utils.b.closeQuietly(cursor);
            throw th;
        }
        com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
        return null;
    }

    public final void oH() {
        Cursor cursorRawQuery = null;
        try {
            try {
                cursorRawQuery = this.OW.rawQuery("select  * from ksad_ad_cache_strategy", null);
                List<e> listA = e.a(cursorRawQuery);
                if (listA != null && !listA.isEmpty()) {
                    for (e eVar : listA) {
                        com.kwad.sdk.core.d.c.d("AdCacheDBManager", "readCacheStrategyList:" + eVar.oM());
                        this.OX.put(eVar.oM(), eVar);
                    }
                }
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            }
        } finally {
            com.kwad.sdk.crash.utils.b.closeQuietly(cursorRawQuery);
        }
    }

    public final void a(final e eVar) {
        this.OX.put(eVar.oM(), eVar);
        GlobalThreadPools.Or().execute(new Runnable() { // from class: com.kwad.components.core.c.a.1
            @Override // java.lang.Runnable
            public final void run() {
                a.this.b(Collections.singletonList(eVar), "ksad_ad_cache_strategy");
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public <T extends j> void b(List<T> list, String str) {
        try {
            this.OW.beginTransaction();
            Iterator<T> it = list.iterator();
            while (it.hasNext()) {
                try {
                    com.kwad.sdk.core.d.c.d("AdCacheDBManager", "insertData: " + str + ", rowId: " + this.OW.insertWithOnConflict(str, null, it.next().oQ(), 5));
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.printStackTrace(e);
                }
            }
            this.OW.setTransactionSuccessful();
        } catch (Exception e2) {
            com.kwad.sdk.core.d.c.printStackTrace(e2);
        } finally {
            SQLiteDatabase sQLiteDatabase = this.OW;
            if (sQLiteDatabase != null) {
                try {
                    sQLiteDatabase.endTransaction();
                } catch (Exception e3) {
                    com.kwad.sdk.core.d.c.printStackTrace(e3);
                }
            }
        }
    }

    /* JADX INFO: renamed from: com.kwad.components.core.c.a$a, reason: collision with other inner class name */
    static class C0418a extends SQLiteOpenHelper {
        private static int Pb = 1;
        private String Pc;
        private String Pd;

        @Override // android.database.sqlite.SQLiteOpenHelper
        public final void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
        }

        public C0418a(Context context) {
            super(context, "ksadcache.db", (SQLiteDatabase.CursorFactory) null, Pb);
            this.Pc = "CREATE TABLE IF NOT EXISTS ksad_ad_cache (creativeId VARCHAR PRIMARY KEY NOT NULL, posId TEXT, adJson TEXT, ecpm INTEGER, playAgainJson TEXT, adSenseJson TEXT, createTime INTEGER, expireTime INTEGER)";
            this.Pd = "CREATE TABLE IF NOT EXISTS ksad_ad_cache_strategy(posId VARCHAR PRIMARY KEY NOT NULL, cacheSize INTEGER, cacheSecond INTEGER, strategyCode INTEGER, enable INTEGER)";
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public final void onCreate(SQLiteDatabase sQLiteDatabase) {
            sQLiteDatabase.execSQL(this.Pc);
            sQLiteDatabase.execSQL(this.Pd);
        }
    }
}
