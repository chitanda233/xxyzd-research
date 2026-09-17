package com.qq.gdt.action.b;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import com.baidu.mobads.sdk.internal.cb;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.qq.gdt.action.i.d;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.u;
import com.qq.gdt.action.i.v;
import com.qq.gdt.action.i.w;
import java.io.File;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.atomic.AtomicInteger;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    private static final String[] d = {"create index index_group on actions ( status,session_id,action_type ) ", "create index index_status_time on actions ( status,revised_action_time ) ", "create index index_time on actions ( revised_action_time ) "};
    private static final String e = "'" + String.join("','", Arrays.asList("TICKET", "RESUME", "PAUSE", "ENTER_BACKGROUND", "ENTER_FOREGROUND")) + "'";
    private static volatile b f;
    private Context g;
    private a h;
    private final File i;
    private SQLiteDatabase k;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private boolean f3022a = false;
    private boolean b = false;
    private boolean c = false;
    private AtomicInteger j = new AtomicInteger();

    private static class a extends SQLiteOpenHelper {
        a(Context context, String str) {
            super(context, str, (SQLiteDatabase.CursorFactory) null, 2);
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onCreate(SQLiteDatabase sQLiteDatabase) {
            o.a("Creating a new gdt_action DB", new Object[0]);
            sQLiteDatabase.execSQL("create table actions ( id INTEGER primary key autoincrement,session_id CHAR(32) not null,unique_id CHAR(32) not null,action_log_id BIGINT not null,action_type TEXT not null,action_time BIGINT not null,action_param TEXT not null,revised_action_time BIGINT not null,status TINYINT not null ) ");
            for (String str : b.d) {
                sQLiteDatabase.execSQL(str);
            }
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onDowngrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
            String str = "Downgrade gdt_action DB， oldVersion: " + i + "，newVersion: " + i2;
            o.a(str, new Object[0]);
            sQLiteDatabase.execSQL("DROP TABLE IF EXISTS actions");
            sQLiteDatabase.execSQL("create table actions ( id INTEGER primary key autoincrement,session_id CHAR(32) not null,unique_id CHAR(32) not null,action_log_id BIGINT not null,action_type TEXT not null,action_time BIGINT not null,action_param TEXT not null,revised_action_time BIGINT not null,status TINYINT not null ) ");
            for (String str2 : b.d) {
                sQLiteDatabase.execSQL(str2);
            }
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
            o.a("Upgrading gdt_action DB， oldVersion: " + i + "，newVersion: " + i2, new Object[0]);
            try {
                sQLiteDatabase.execSQL("alter table actions add action_log_id default -1 ");
            } catch (Exception e) {
                o.c(e.getMessage());
            }
        }
    }

    private b(Context context) {
        this.g = context.getApplicationContext();
        String str = "gdt_action_" + u.a(d.a(this.g)) + ".db";
        o.a("ActionDB full name is " + str, new Object[0]);
        this.h = new a(this.g, str);
        this.i = this.g.getDatabasePath(str);
    }

    private int a(SQLiteDatabase sQLiteDatabase) {
        long jA = c.a();
        int iDelete = sQLiteDatabase.delete("actions", "( action_time < ? ) OR ( revised_action_time > 0 AND revised_action_time < ? )", new String[]{String.valueOf(jA), String.valueOf(jA)});
        if (iDelete > 0) {
            com.qq.gdt.action.g.a.a(AVMDLDataLoader.KeyIsStoIoWriteLimitKBTh1);
        }
        return iDelete;
    }

    private int a(SQLiteDatabase sQLiteDatabase, int i) {
        sQLiteDatabase.execSQL("DELETE FROM actions WHERE id IN (SELECT id FROM actions WHERE action_type IN (" + e + ") AND status != 1 ORDER BY action_time ASC LIMIT ?)", new String[]{String.valueOf(i)});
        if (i > 0 && !this.f3022a) {
            this.f3022a = true;
            com.qq.gdt.action.g.a.a(AVMDLDataLoader.KeyIsStoMaxIdleTimeSec);
        }
        return i;
    }

    private ContentValues a(com.qq.gdt.action.b.a aVar) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("session_id", aVar.g());
        contentValues.put("unique_id", aVar.a());
        contentValues.put("action_log_id", Long.valueOf(aVar.b()));
        contentValues.put("action_type", aVar.c());
        contentValues.put("action_time", Long.valueOf(aVar.d()));
        contentValues.put("action_param", aVar.e() == null ? "" : aVar.e().toString());
        contentValues.put("revised_action_time", Long.valueOf(aVar.h()));
        contentValues.put("status", (Integer) 0);
        return contentValues;
    }

    public static b a(Context context) {
        if (f == null) {
            synchronized (b.class) {
                if (f == null) {
                    f = new b(context);
                }
            }
        }
        return f;
    }

    private void a(SQLiteDatabase sQLiteDatabase, Cursor cursor, boolean z) {
        if (cursor != null) {
            try {
                cursor.close();
            } catch (Throwable th) {
                o.a("Cursor close exception", th);
            }
        }
        if (sQLiteDatabase != null) {
            if (z) {
                try {
                    sQLiteDatabase.endTransaction();
                } catch (Throwable th2) {
                    o.a("Database close exception", th2);
                    return;
                }
            }
            d();
        }
    }

    private String b(int i) {
        if (i == 0) {
            return "pending";
        }
        if (i == 1) {
            return cb.o;
        }
        if (i == 2) {
            return "fail";
        }
        if (i != 3) {
            return i != 4 ? "unknown" : "abandon";
        }
        return "ignore";
    }

    private void b(SQLiteDatabase sQLiteDatabase, int i) throws Throwable {
        String str;
        String str2;
        if (i == 0) {
            str = " WHERE action_type IN (" + e + ") AND status != 1";
            str2 = "Remaining non-critical actions (non-success):";
        } else if (i == 1) {
            str = " WHERE action_type NOT IN (" + e + ") AND action_type NOT IN ('START_APP', 'TENCENT_INNER_START_APP') AND status != 1";
            str2 = "Remaining critical actions (non-success, excluding START_APP):";
        } else if (i == 2) {
            str = " WHERE action_type IN ('START_APP', 'TENCENT_INNER_START_APP') AND status != 1";
            str2 = "Remaining START_APP actions (including TENCENT_INNER_START_APP, non-success):";
        } else {
            str = "";
            str2 = "All actions (all types and all statuses):";
        }
        Cursor cursorRawQuery = null;
        try {
            cursorRawQuery = sQLiteDatabase.rawQuery("SELECT id, action_type, action_time, status, action_log_id FROM actions" + str + " ORDER BY action_time ASC", null);
            if (cursorRawQuery != null) {
                o.a(str2, new Object[0]);
                while (cursorRawQuery.moveToNext()) {
                    long j = cursorRawQuery.getLong(0);
                    String string = cursorRawQuery.getString(1);
                    long j2 = cursorRawQuery.getLong(2);
                    int i2 = cursorRawQuery.getInt(3);
                    long j3 = cursorRawQuery.getLong(4);
                    if (i == 3) {
                        try {
                            o.a("ActionLogId=%d, ID=%d, Type=%s, Time=%d, Status=%d(%s)", Long.valueOf(j3), Long.valueOf(j), string, Long.valueOf(j2), Integer.valueOf(i2), b(i2));
                        } catch (Throwable th) {
                            th = th;
                            if (cursorRawQuery != null) {
                                cursorRawQuery.close();
                            }
                            throw th;
                        }
                    } else {
                        o.a("ActionLogId=%d, ID=%d, Type=%s, Time=%d", Long.valueOf(j3), Long.valueOf(j), string, Long.valueOf(j2));
                    }
                }
            }
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    private void b(List<com.qq.gdt.action.b.a> list) throws Throwable {
        if (list != null) {
            try {
                if (list.isEmpty()) {
                    return;
                }
                Iterator<com.qq.gdt.action.b.a> it = list.iterator();
                boolean z = false;
                boolean z2 = false;
                boolean z3 = false;
                while (it.hasNext()) {
                    String strC = it.next().c();
                    if (c.a(strC)) {
                        z3 = true;
                    } else if (c.b(strC)) {
                        z = true;
                    } else {
                        z2 = true;
                    }
                    if (z && z2 && z3) {
                        break;
                    }
                }
                if (z) {
                    i();
                }
                if (z2) {
                    j();
                }
                if (z3) {
                    k();
                }
            } catch (Exception e2) {
                o.b("Clean excess actions exception", e2);
            }
        }
    }

    /* JADX WARN: Code duplicated, block: B:15:0x0053 A[DONT_GENERATE, PHI: r4
  0x0053: PHI (r4v3 android.database.Cursor) = (r4v2 android.database.Cursor), (r4v4 android.database.Cursor) binds: [B:14:0x0051, B:8:0x0046] A[DONT_GENERATE, DONT_INLINE]] */
    private int[] b(SQLiteDatabase sQLiteDatabase) {
        int[] iArr = new int[3];
        Cursor cursorRawQuery = null;
        try {
            StringBuilder sb = new StringBuilder("SELECT SUM(CASE WHEN action_type IN (");
            String str = e;
            cursorRawQuery = sQLiteDatabase.rawQuery(sb.append(str).append(") THEN 1 ELSE 0 END) as non_critical, SUM(CASE WHEN action_type IN ('START_APP', 'TENCENT_INNER_START_APP') THEN 1 ELSE 0 END) as start_app, SUM(CASE WHEN action_type NOT IN (").append(str).append(") AND action_type NOT IN ('START_APP', 'TENCENT_INNER_START_APP') THEN 1 ELSE 0 END) as critical FROM actions WHERE status != 1").toString(), null);
            if (cursorRawQuery != null && cursorRawQuery.moveToFirst()) {
                iArr[0] = cursorRawQuery.getInt(0);
                iArr[1] = cursorRawQuery.getInt(2);
                iArr[2] = cursorRawQuery.getInt(1);
            }
        } catch (Exception e2) {
            o.b("Get action counts exception", e2);
        } finally {
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
        }
        return iArr;
    }

    private int c(SQLiteDatabase sQLiteDatabase, int i) {
        sQLiteDatabase.execSQL("DELETE FROM actions WHERE id IN (SELECT id FROM actions WHERE action_type NOT IN (" + e + ") AND action_type NOT IN ('START_APP', 'TENCENT_INNER_START_APP') AND status != 1 ORDER BY action_time ASC LIMIT ?)", new String[]{String.valueOf(i)});
        if (i > 0 && !this.b) {
            this.b = true;
            com.qq.gdt.action.g.a.a(AVMDLDataLoader.KeyIsStoIoWriteLimitKBTh2);
        }
        return i;
    }

    private synchronized SQLiteDatabase c() {
        if (this.j.incrementAndGet() == 1) {
            try {
                this.k = this.h.getWritableDatabase();
            } catch (Throwable th) {
                o.a("database open exception", th);
            }
        }
        return this.k;
    }

    private void c(int i) {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                a(sQLiteDatabaseC, i);
            } catch (Throwable th) {
                th = th;
                try {
                    o.b("Exception while delete oldest non-critical actions", th);
                } finally {
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
            }
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseC = null;
        }
    }

    private int d(SQLiteDatabase sQLiteDatabase, int i) {
        sQLiteDatabase.execSQL("DELETE FROM actions WHERE id IN (SELECT id FROM actions WHERE action_type IN ('START_APP', 'TENCENT_INNER_START_APP') AND status != 1 ORDER BY action_time ASC LIMIT ?)", new String[]{String.valueOf(i)});
        if (i > 0 && !this.c) {
            this.c = true;
            com.qq.gdt.action.g.a.a(10007);
        }
        return i;
    }

    private synchronized void d() {
        SQLiteDatabase sQLiteDatabase;
        if (this.j.decrementAndGet() == 0 && (sQLiteDatabase = this.k) != null) {
            try {
                sQLiteDatabase.close();
            } catch (Throwable th) {
                o.a("database close exception", th);
            }
        }
    }

    private void d(int i) {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                c(sQLiteDatabaseC, i);
            } catch (Throwable th) {
                th = th;
                try {
                    o.b("Exception while delete oldest critical actions", th);
                } finally {
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
            }
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseC = null;
        }
    }

    private int e() {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                String[] strArr = {String.valueOf(System.currentTimeMillis() - 1296000000), String.valueOf(w.b() - 54000000)};
                o.a("Will delete actions with query:( status = 1 ) AND ( ( action_time < ? ) OR ( revised_action_time > 0 AND revised_action_time < ? )), values:" + Arrays.toString(strArr), new Object[0]);
                int iDelete = sQLiteDatabaseC.delete("actions", "( status = 1 ) AND ( ( action_time < ? ) OR ( revised_action_time > 0 AND revised_action_time < ? ))", strArr);
                a(sQLiteDatabaseC, (Cursor) null, false);
                return iDelete;
            } catch (Throwable unused) {
                try {
                    o.c("Exception while delete actions out of date");
                    return 0;
                } finally {
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
            }
        } catch (Throwable unused2) {
            sQLiteDatabaseC = null;
        }
    }

    private void e(int i) {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                d(sQLiteDatabaseC, i);
            } catch (Throwable th) {
                th = th;
                try {
                    o.b("Exception while delete oldest START_APP actions", th);
                } finally {
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
            }
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseC = null;
        }
    }

    private int f() {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                o.a("Will delete auto actions with query:( status = 1 ) AND (action_type in ('TICKET', 'PAGE_VIEW', 'RESUME', 'PAUSE', 'ENTER_BACKGROUND', 'ENTER_FOREGROUND')), values:", new Object[0]);
                int iDelete = sQLiteDatabaseC.delete("actions", "( status = 1 ) AND (action_type in ('TICKET', 'PAGE_VIEW', 'RESUME', 'PAUSE', 'ENTER_BACKGROUND', 'ENTER_FOREGROUND'))", null);
                a(sQLiteDatabaseC, (Cursor) null, false);
                return iDelete;
            } catch (Throwable unused) {
                try {
                    o.c("Exception while delete actions outOfDate");
                    return 0;
                } finally {
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
            }
        } catch (Throwable unused2) {
            sQLiteDatabaseC = null;
        }
    }

    private int g() {
        Cursor cursor;
        SQLiteDatabase sQLiteDatabase = null;
        Cursor cursorRawQuery = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT COUNT(*) FROM actions", null);
                if (cursorRawQuery == null || !cursorRawQuery.moveToFirst()) {
                    a(sQLiteDatabaseC, cursorRawQuery, false);
                    return -1;
                }
                int i = cursorRawQuery.getInt(0);
                a(sQLiteDatabaseC, cursorRawQuery, false);
                return i;
            } catch (Throwable th) {
                th = th;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                try {
                    o.b("Exception while count all actions in db", th);
                    return -1;
                } finally {
                    a(sQLiteDatabase, cursor, false);
                }
            }
        } catch (Throwable th2) {
            th = th2;
            cursor = null;
        }
    }

    /* JADX WARN: Code duplicated, block: B:46:0x0095 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    private void h() throws Throwable {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                try {
                    sQLiteDatabaseC.beginTransaction();
                    int iA = a(sQLiteDatabaseC);
                    int[] iArrB = b(sQLiteDatabaseC);
                    int i = iArrB[0];
                    int i2 = iArrB[1];
                    int i3 = iArrB[2];
                    int iA2 = i > 100 ? a(sQLiteDatabaseC, i - 100) : 0;
                    int iC = i2 > 1000 ? c(sQLiteDatabaseC, i2 - 1000) : 0;
                    int iD = i3 > 100 ? d(sQLiteDatabaseC, i3 - 100) : 0;
                    sQLiteDatabaseC.setTransactionSuccessful();
                    o.a("Storage policy enforced successfully - Expired: " + iA + ", NonCritical: " + iA2 + ", Critical: " + iC + ", StartApp: " + iD, new Object[0]);
                    if (sQLiteDatabaseC != null) {
                        try {
                            sQLiteDatabaseC.endTransaction();
                        } catch (Exception e2) {
                            e = e2;
                            o.b("Error ending transaction", e);
                        }
                        a(sQLiteDatabaseC, (Cursor) null, false);
                    }
                } catch (Exception e3) {
                    e = e3;
                    o.b("Error enforcing storage policy", e);
                    if (sQLiteDatabaseC == null) {
                        return;
                    }
                    try {
                        sQLiteDatabaseC.endTransaction();
                    } catch (Exception e4) {
                        e = e4;
                        o.b("Error ending transaction", e);
                    }
                }
            } catch (Throwable th) {
                th = th;
                if (sQLiteDatabaseC != null) {
                    try {
                        sQLiteDatabaseC.endTransaction();
                    } catch (Exception e5) {
                        o.b("Error ending transaction", e5);
                    }
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
                throw th;
            }
        } catch (Exception e6) {
            e = e6;
            sQLiteDatabaseC = null;
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseC = null;
            if (sQLiteDatabaseC != null) {
                sQLiteDatabaseC.endTransaction();
                a(sQLiteDatabaseC, (Cursor) null, false);
            }
            throw th;
        }
    }

    private void i() throws Throwable {
        int iL = l();
        if (iL >= 100) {
            int iMax = Math.max(1, (iL - 100) + 1);
            c(iMax);
            o.a("Cleaned " + iMax + " excess non-critical actions (non-success status only, total limit: 100, was: " + iL + ")", new Object[0]);
        }
    }

    private void j() throws Throwable {
        int iM = m();
        if (iM >= 1000) {
            int iMax = Math.max(1, (iM - 1000) + 1);
            d(iMax);
            o.a("Cleaned " + iMax + " excess critical actions (non-success status only, limit: 1000)", new Object[0]);
        }
    }

    private void k() throws Throwable {
        int iN = n();
        if (iN >= 100) {
            int iMax = Math.max(1, (iN - 100) + 1);
            e(iMax);
            o.a("Cleaned " + iMax + " excess START_APP actions (including TENCENT_INNER_START_APP, non-success status only, limit: 100)", new Object[0]);
        }
    }

    private int l() throws Throwable {
        Cursor cursor;
        SQLiteDatabase sQLiteDatabase = null;
        cursorRawQuery = null;
        Cursor cursorRawQuery = null;
        sQLiteDatabase = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT COUNT(*) FROM actions WHERE action_type IN (" + e + ") AND status != 1", null);
                int i = (cursorRawQuery == null || !cursorRawQuery.moveToFirst()) ? 0 : cursorRawQuery.getInt(0);
                a(sQLiteDatabaseC, cursorRawQuery, false);
                return i;
            } catch (Exception e2) {
                e = e2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                try {
                    o.b("Count non-critical actions exception", e);
                    a(sQLiteDatabase, cursor, false);
                    return 0;
                } catch (Throwable th) {
                    th = th;
                    a(sQLiteDatabase, cursor, false);
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                a(sQLiteDatabase, cursor, false);
                throw th;
            }
        } catch (Exception e3) {
            e = e3;
            cursor = null;
        } catch (Throwable th3) {
            th = th3;
            cursor = null;
        }
    }

    private int m() throws Throwable {
        Cursor cursor;
        SQLiteDatabase sQLiteDatabase = null;
        cursorRawQuery = null;
        Cursor cursorRawQuery = null;
        sQLiteDatabase = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT COUNT(*) FROM actions WHERE action_type NOT IN (" + e + ") AND action_type NOT IN ('START_APP', 'TENCENT_INNER_START_APP') AND status != 1", null);
                int i = (cursorRawQuery == null || !cursorRawQuery.moveToFirst()) ? 0 : cursorRawQuery.getInt(0);
                a(sQLiteDatabaseC, cursorRawQuery, false);
                return i;
            } catch (Exception e2) {
                e = e2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                try {
                    o.b("Count critical actions exception", e);
                    a(sQLiteDatabase, cursor, false);
                    return 0;
                } catch (Throwable th) {
                    th = th;
                    a(sQLiteDatabase, cursor, false);
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                a(sQLiteDatabase, cursor, false);
                throw th;
            }
        } catch (Exception e3) {
            e = e3;
            cursor = null;
        } catch (Throwable th3) {
            th = th3;
            cursor = null;
        }
    }

    private int n() throws Throwable {
        Cursor cursor;
        SQLiteDatabase sQLiteDatabase = null;
        cursorRawQuery = null;
        Cursor cursorRawQuery = null;
        sQLiteDatabase = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT COUNT(*) FROM actions WHERE action_type IN ('START_APP', 'TENCENT_INNER_START_APP') AND status != 1", null);
                int i = (cursorRawQuery == null || !cursorRawQuery.moveToFirst()) ? 0 : cursorRawQuery.getInt(0);
                a(sQLiteDatabaseC, cursorRawQuery, false);
                return i;
            } catch (Exception e2) {
                e = e2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                try {
                    o.b("Count START_APP actions exception", e);
                    a(sQLiteDatabase, cursor, false);
                    return 0;
                } catch (Throwable th) {
                    th = th;
                    a(sQLiteDatabase, cursor, false);
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                a(sQLiteDatabase, cursor, false);
                throw th;
            }
        } catch (Exception e3) {
            e = e3;
            cursor = null;
        } catch (Throwable th3) {
            th = th3;
            cursor = null;
        }
    }

    public int a(int i) throws Throwable {
        Cursor cursor;
        int i2 = -1;
        SQLiteDatabase sQLiteDatabase = null;
        cursorRawQuery = null;
        Cursor cursorRawQuery = null;
        sQLiteDatabase = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT COUNT(*) FROM actions WHERE status = " + i, null);
                if (cursorRawQuery != null) {
                    cursorRawQuery.moveToFirst();
                    i2 = cursorRawQuery.getInt(0);
                }
                a(sQLiteDatabaseC, cursorRawQuery, false);
            } catch (Exception e2) {
                e = e2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                try {
                    o.b("Count failed action exception", e);
                    a(sQLiteDatabase, cursor, false);
                } catch (Throwable th) {
                    th = th;
                    a(sQLiteDatabase, cursor, false);
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                cursor = cursorRawQuery;
                sQLiteDatabase = sQLiteDatabaseC;
                a(sQLiteDatabase, cursor, false);
                throw th;
            }
        } catch (Exception e3) {
            e = e3;
            cursor = null;
        } catch (Throwable th3) {
            th = th3;
            cursor = null;
        }
        return i2;
    }

    public synchronized int a(List<com.qq.gdt.action.b.a> list, int i) {
        SQLiteDatabase sQLiteDatabaseC;
        int iUpdate;
        try {
            try {
                sQLiteDatabaseC = c();
                try {
                    try {
                        ContentValues contentValues = new ContentValues();
                        contentValues.put("status", Integer.valueOf(i));
                        String[] strArr = new String[list.size()];
                        StringBuilder sb = new StringBuilder();
                        sb.append("id").append(" IN ").append(" ( ");
                        for (int i2 = 0; i2 < list.size(); i2++) {
                            strArr[i2] = String.valueOf(list.get(i2).f());
                            if (i2 == list.size() - 1) {
                                sb.append("?");
                            } else {
                                sb.append("?").append(", ");
                            }
                        }
                        sb.append(" ) ");
                        iUpdate = sQLiteDatabaseC.update("actions", contentValues, sb.toString(), strArr);
                        a(sQLiteDatabaseC, (Cursor) null, false);
                    } catch (Exception e2) {
                        e = e2;
                        o.b("Database update actions status exception.", e);
                        a(sQLiteDatabaseC, (Cursor) null, false);
                        iUpdate = -3;
                    }
                } catch (Throwable th) {
                    th = th;
                    a(sQLiteDatabaseC, (Cursor) null, false);
                    throw th;
                }
            } catch (Throwable th2) {
                throw th2;
            }
        } catch (Exception e3) {
            e = e3;
            sQLiteDatabaseC = null;
        } catch (Throwable th3) {
            th = th3;
            sQLiteDatabaseC = null;
            a(sQLiteDatabaseC, (Cursor) null, false);
            throw th;
        }
        return iUpdate;
    }

    public List<com.qq.gdt.action.b.a> a(int i, long j, long j2) throws Throwable {
        Cursor cursorRawQuery;
        ArrayList arrayList = new ArrayList();
        SQLiteDatabase sQLiteDatabase = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT * FROM actions WHERE status = " + i + " AND id > " + j2 + " ORDER BY id ASC LIMIT " + j, null);
                if (cursorRawQuery != null) {
                    while (cursorRawQuery.moveToNext()) {
                        try {
                            long j3 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("id"));
                            String string = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("session_id"));
                            String string2 = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("unique_id"));
                            long j4 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("action_log_id"));
                            String string3 = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("action_type"));
                            long j5 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("action_time"));
                            long j6 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("revised_action_time"));
                            String string4 = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("action_param"));
                            arrayList.add(new com.qq.gdt.action.b.a(j3, string, string2, string3, j5, j6, v.a(string4) ? null : new JSONObject(string4), i, j4));
                        } catch (Exception e2) {
                            e = e2;
                            sQLiteDatabase = sQLiteDatabaseC;
                            try {
                                o.b("Find actions by status exception", e);
                                a(sQLiteDatabase, cursorRawQuery, false);
                            } catch (Throwable th) {
                                th = th;
                                a(sQLiteDatabase, cursorRawQuery, false);
                                throw th;
                            }
                        } catch (Throwable th2) {
                            th = th2;
                            sQLiteDatabase = sQLiteDatabaseC;
                            a(sQLiteDatabase, cursorRawQuery, false);
                            throw th;
                        }
                    }
                }
                a(sQLiteDatabaseC, cursorRawQuery, false);
            } catch (Exception e3) {
                e = e3;
                cursorRawQuery = null;
            } catch (Throwable th3) {
                th = th3;
                cursorRawQuery = null;
            }
        } catch (Exception e4) {
            e = e4;
            cursorRawQuery = null;
        } catch (Throwable th4) {
            th = th4;
            cursorRawQuery = null;
        }
        return arrayList;
    }

    public void a() throws Throwable {
        o.a("Success cleaned " + e() + " out of date actions.", new Object[0]);
        h();
        if (g() > 2000) {
            o.a("Success deep-clean " + f() + " out of date actions.", new Object[0]);
        }
    }

    public boolean a(List<com.qq.gdt.action.b.a> list) throws Throwable {
        SQLiteDatabase sQLiteDatabaseC;
        boolean z;
        boolean z2 = false;
        o.a("addActionList: %s", list);
        b(list);
        try {
            sQLiteDatabaseC = c();
            try {
                try {
                    sQLiteDatabaseC.beginTransaction();
                    Iterator<com.qq.gdt.action.b.a> it = list.iterator();
                    while (true) {
                        if (!it.hasNext()) {
                            z = true;
                            break;
                        }
                        com.qq.gdt.action.b.a next = it.next();
                        long jInsert = sQLiteDatabaseC.insert("actions", null, a(next));
                        if (jInsert < 0) {
                            com.qq.gdt.action.g.a.a(6004, next);
                            z = false;
                            break;
                        }
                        next.a(jInsert);
                    }
                    b(sQLiteDatabaseC, 1);
                    if (z) {
                        sQLiteDatabaseC.setTransactionSuccessful();
                    }
                    a(sQLiteDatabaseC, (Cursor) null, true);
                    z2 = z;
                } catch (Exception e2) {
                    e = e2;
                    o.b("Database add actions exception.", e);
                    Iterator<com.qq.gdt.action.b.a> it2 = list.iterator();
                    while (it2.hasNext()) {
                        com.qq.gdt.action.g.a.a(6005, it2.next());
                    }
                    a(sQLiteDatabaseC, (Cursor) null, true);
                }
            } catch (Throwable th) {
                th = th;
                a(sQLiteDatabaseC, (Cursor) null, true);
                throw th;
            }
        } catch (Exception e3) {
            e = e3;
            sQLiteDatabaseC = null;
        } catch (Throwable th2) {
            th = th2;
            sQLiteDatabaseC = null;
            a(sQLiteDatabaseC, (Cursor) null, true);
            throw th;
        }
        if (!z2) {
            Iterator<com.qq.gdt.action.b.a> it3 = list.iterator();
            while (it3.hasNext()) {
                it3.next().a(-1L);
            }
        }
        return z2;
    }
}
