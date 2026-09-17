package com.qq.gdt.action.b.a;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import com.qq.gdt.action.i.d;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.u;
import com.qq.gdt.action.i.v;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.atomic.AtomicInteger;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String[] f3021a = {"create index index_group on events ( status,session_id,action_type ) "};
    private static volatile a b;
    private Context c;
    private C0550a d;
    private AtomicInteger e = new AtomicInteger();
    private SQLiteDatabase f;

    /* JADX INFO: renamed from: com.qq.gdt.action.b.a.a$a, reason: collision with other inner class name */
    private static class C0550a extends SQLiteOpenHelper {
        C0550a(Context context, String str) {
            super(context, str, (SQLiteDatabase.CursorFactory) null, 2);
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onCreate(SQLiteDatabase sQLiteDatabase) {
            o.a("Creating a new gdt_event DB", new Object[0]);
            sQLiteDatabase.execSQL("create table events ( id INTEGER primary key autoincrement,event_id INTEGER not null,unique_event_id CHAR(32) not null,event_time BIGINT not null,action_type TEXT,unique_action_id CHAR(32),action_log_id BIGINT not null,event_log_id BIGINT not null,action_time BIGINT,event_param TEXT not null,session_id CHAR(32) not null,status TINYINT not null ) ");
            for (String str : a.f3021a) {
                sQLiteDatabase.execSQL(str);
            }
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onDowngrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
            String str = "Downgrade gdt_action DB， oldVersion: " + i + "，newVersion: " + i2;
            o.a(str, new Object[0]);
            sQLiteDatabase.execSQL("DROP TABLE IF EXISTS events");
            sQLiteDatabase.execSQL("create table events ( id INTEGER primary key autoincrement,event_id INTEGER not null,unique_event_id CHAR(32) not null,event_time BIGINT not null,action_type TEXT,unique_action_id CHAR(32),action_log_id BIGINT not null,event_log_id BIGINT not null,action_time BIGINT,event_param TEXT not null,session_id CHAR(32) not null,status TINYINT not null ) ");
            for (String str2 : a.f3021a) {
                sQLiteDatabase.execSQL(str2);
            }
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
            o.a("Upgrading gdt_event DB， oldVersion: " + i + "，newVersion: " + i2, new Object[0]);
            try {
                sQLiteDatabase.execSQL("alter table events add action_log_id default -1 ");
                sQLiteDatabase.execSQL("alter table events add event_log_id default -1 ");
            } catch (Exception e) {
                o.c(e.getMessage());
            }
        }
    }

    private a(Context context) {
        this.c = context.getApplicationContext();
        String str = "gdt_event_" + u.a(d.a(this.c)) + ".db";
        o.a("ActionDB full name is " + str, new Object[0]);
        this.d = new C0550a(this.c, str);
    }

    private int a(SQLiteDatabase sQLiteDatabase) {
        int i = 0;
        Cursor cursorRawQuery = null;
        try {
            try {
                try {
                    cursorRawQuery = sQLiteDatabase.rawQuery("SELECT COUNT(*) FROM events WHERE status != 1", null);
                    if (cursorRawQuery != null && cursorRawQuery.moveToFirst()) {
                        i = cursorRawQuery.getInt(0);
                    }
                    if (cursorRawQuery != null) {
                        cursorRawQuery.close();
                    }
                } catch (Throwable th) {
                    if (cursorRawQuery != null) {
                        try {
                            cursorRawQuery.close();
                        } catch (Throwable th2) {
                            o.a("Cursor close exception", th2);
                        }
                    }
                    throw th;
                }
            } catch (Exception e) {
                o.b("Count non-success events exception", e);
                if (cursorRawQuery != null) {
                    cursorRawQuery.close();
                }
            }
        } catch (Throwable th3) {
            o.a("Cursor close exception", th3);
        }
        return i;
    }

    private ContentValues a(com.qq.gdt.action.f.a.a aVar) {
        ContentValues contentValues = new ContentValues();
        contentValues.put("event_id", Long.valueOf(aVar.b()));
        contentValues.put("unique_event_id", aVar.d());
        contentValues.put("event_time", Long.valueOf(aVar.i()));
        contentValues.put("action_type", aVar.f());
        contentValues.put("unique_action_id", aVar.e());
        contentValues.put("action_log_id", Long.valueOf(aVar.j()));
        contentValues.put("event_log_id", Long.valueOf(aVar.k()));
        contentValues.put("action_time", Long.valueOf(aVar.g()));
        contentValues.put("event_param", aVar.h() == null ? "" : aVar.h().toString());
        contentValues.put("session_id", aVar.c());
        contentValues.put("status", (Integer) 0);
        return contentValues;
    }

    public static a a(Context context) {
        if (b == null) {
            synchronized (a.class) {
                if (b == null) {
                    b = new a(context);
                }
            }
        }
        return b;
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
                    if (sQLiteDatabase.inTransaction()) {
                        sQLiteDatabase.endTransaction();
                    }
                } catch (Throwable th2) {
                    o.a("Database close exception", th2);
                    return;
                }
            }
            d();
        }
    }

    private synchronized SQLiteDatabase c() {
        if (this.e.incrementAndGet() == 1) {
            try {
                this.f = this.d.getWritableDatabase();
            } catch (Throwable th) {
                o.a("database open exception", th);
            }
        }
        return this.f;
    }

    private synchronized void d() {
        SQLiteDatabase sQLiteDatabase;
        if (this.e.decrementAndGet() == 0 && (sQLiteDatabase = this.f) != null) {
            try {
                sQLiteDatabase.close();
            } catch (Throwable th) {
                o.a("database close exception", th);
            }
        }
    }

    private int e() {
        SQLiteDatabase sQLiteDatabaseC;
        try {
            sQLiteDatabaseC = c();
            try {
                int iDelete = sQLiteDatabaseC.delete("events", "( status = 1 ) ", null);
                a(sQLiteDatabaseC, (Cursor) null, false);
                return iDelete;
            } catch (Throwable unused) {
                try {
                    o.c("Exception while delete events outOfDate");
                    return 0;
                } finally {
                    a(sQLiteDatabaseC, (Cursor) null, false);
                }
            }
        } catch (Throwable unused2) {
            sQLiteDatabaseC = null;
        }
    }

    /* JADX WARN: Code duplicated, block: B:11:0x0020  */
    /* JADX WARN: Code duplicated, block: B:14:0x0025 A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:15:0x0027 A[Catch: all -> 0x001d, TryCatch #2 {all -> 0x001d, blocks: (B:6:0x0012, B:8:0x0018, B:15:0x0027, B:16:0x002b), top: B:53:0x0012 }] */
    /* JADX WARN: Code duplicated, block: B:22:0x0040  */
    /* JADX WARN: Code duplicated, block: B:25:0x0045 A[Catch: all -> 0x007b, TRY_LEAVE, TryCatch #1 {all -> 0x007b, blocks: (B:4:0x000a, B:19:0x0035, B:21:0x003b, B:25:0x0045), top: B:51:0x000a }] */
    /* JADX WARN: Code duplicated, block: B:30:0x0073  */
    /* JADX WARN: Code duplicated, block: B:31:0x0074 A[PHI: r5
  0x0074: PHI (r5v8 android.database.Cursor) = (r5v6 android.database.Cursor), (r5v13 android.database.Cursor) binds: [B:13:0x0023, B:30:0x0073] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:33:0x0077  */
    /* JADX WARN: Code duplicated, block: B:42:0x008a A[DONT_GENERATE] */
    /* JADX WARN: Code duplicated, block: B:59:? A[RETURN, SYNTHETIC] */
    private int f() {
        Cursor cursorRawQuery;
        int i;
        int i2;
        int i3;
        long j;
        int iDelete;
        SQLiteDatabase sQLiteDatabase = null;
        Cursor cursorRawQuery2 = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT COUNT(*) FROM events WHERE status != 1", null);
                if (cursorRawQuery == null) {
                    i2 = 0;
                    if (i2 <= 10) {
                        i3 = 0;
                    } else {
                        if (cursorRawQuery != null) {
                            cursorRawQuery.close();
                            cursorRawQuery = null;
                        }
                        cursorRawQuery2 = sQLiteDatabaseC.rawQuery("SELECT id FROM events WHERE status != 1 ORDER BY id DESC LIMIT 10", null);
                        if (cursorRawQuery2 == null) {
                            j = 0;
                        } else {
                            j = 0;
                        }
                        if (j > 0) {
                            iDelete = sQLiteDatabaseC.delete("events", "id < ? AND status != 1", new String[]{String.valueOf(j)});
                            o.a("Limit non-success events: deleted " + iDelete + " old events, kept latest 10 events.", new Object[0]);
                            i3 = iDelete;
                            cursorRawQuery = cursorRawQuery2;
                        } else {
                            cursorRawQuery = cursorRawQuery2;
                            i3 = 0;
                        }
                    }
                    if (sQLiteDatabaseC != null) {
                        return i3;
                    }
                    a(sQLiteDatabaseC, cursorRawQuery, false);
                    return i3;
                }
                try {
                    if (cursorRawQuery.moveToFirst()) {
                        i2 = cursorRawQuery.getInt(0);
                    } else {
                        i2 = 0;
                    }
                    if (i2 <= 10) {
                        i3 = 0;
                    } else {
                        if (cursorRawQuery != null) {
                            cursorRawQuery.close();
                            cursorRawQuery = null;
                        }
                        cursorRawQuery2 = sQLiteDatabaseC.rawQuery("SELECT id FROM events WHERE status != 1 ORDER BY id DESC LIMIT 10", null);
                        if (cursorRawQuery2 == null && cursorRawQuery2.moveToLast()) {
                            j = cursorRawQuery2.getLong(0);
                        } else {
                            j = 0;
                        }
                        if (j > 0) {
                            iDelete = sQLiteDatabaseC.delete("events", "id < ? AND status != 1", new String[]{String.valueOf(j)});
                            try {
                                o.a("Limit non-success events: deleted " + iDelete + " old events, kept latest 10 events.", new Object[0]);
                                i3 = iDelete;
                                cursorRawQuery = cursorRawQuery2;
                            } catch (Throwable th) {
                                th = th;
                                i = iDelete;
                                cursorRawQuery = cursorRawQuery2;
                                sQLiteDatabase = sQLiteDatabaseC;
                                o.b("Exception while limiting non-success events", th);
                                return i;
                            }
                        } else {
                            cursorRawQuery = cursorRawQuery2;
                            i3 = 0;
                        }
                    }
                    if (sQLiteDatabaseC != null) {
                        return i3;
                    }
                    a(sQLiteDatabaseC, cursorRawQuery, false);
                    return i3;
                } catch (Throwable th2) {
                    th = th2;
                    i = 0;
                    sQLiteDatabase = sQLiteDatabaseC;
                    o.b("Exception while limiting non-success events", th);
                    return i;
                }
            } catch (Throwable th3) {
                th = th3;
                cursorRawQuery = cursorRawQuery2;
            }
        } catch (Throwable th4) {
            th = th4;
            cursorRawQuery = null;
            i = 0;
        }
        try {
            o.b("Exception while limiting non-success events", th);
            return i;
        } finally {
            if (sQLiteDatabase != null) {
                a(sQLiteDatabase, cursorRawQuery, false);
            }
        }
    }

    public synchronized int a(List<com.qq.gdt.action.f.a.a> list, int i) {
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
                            strArr[i2] = String.valueOf(list.get(i2).a());
                            if (i2 == list.size() - 1) {
                                sb.append("?");
                            } else {
                                sb.append("?").append(", ");
                            }
                        }
                        sb.append(" ) ");
                        iUpdate = sQLiteDatabaseC.update("events", contentValues, sb.toString(), strArr);
                        a(sQLiteDatabaseC, (Cursor) null, false);
                    } catch (Exception e) {
                        e = e;
                        o.b("Database update events status exception.", e);
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
        } catch (Exception e2) {
            e = e2;
            sQLiteDatabaseC = null;
        } catch (Throwable th3) {
            th = th3;
            sQLiteDatabaseC = null;
            a(sQLiteDatabaseC, (Cursor) null, false);
            throw th;
        }
        return iUpdate;
    }

    public List<com.qq.gdt.action.f.a.a> a(int i, long j, long j2) throws Throwable {
        Cursor cursorRawQuery;
        ArrayList arrayList = new ArrayList();
        SQLiteDatabase sQLiteDatabase = null;
        try {
            SQLiteDatabase sQLiteDatabaseC = c();
            try {
                cursorRawQuery = sQLiteDatabaseC.rawQuery("SELECT * FROM events WHERE status = " + i + " AND id > " + j2 + " ORDER BY id ASC LIMIT " + j, null);
                if (cursorRawQuery != null) {
                    while (cursorRawQuery.moveToNext()) {
                        try {
                            long j3 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("id"));
                            long j4 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("event_id"));
                            String string = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("unique_event_id"));
                            long j5 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("event_time"));
                            String string2 = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("action_type"));
                            String string3 = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("unique_action_id"));
                            long j6 = cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("action_time"));
                            String string4 = cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("event_param"));
                            arrayList.add(new com.qq.gdt.action.f.a.a(j3, j4, string, j5, cursorRawQuery.getString(cursorRawQuery.getColumnIndexOrThrow("session_id")), string2, string3, j6, v.a(string4) ? null : new JSONObject(string4), i, cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("action_log_id")), cursorRawQuery.getLong(cursorRawQuery.getColumnIndexOrThrow("event_log_id"))));
                        } catch (Exception e) {
                            e = e;
                            sQLiteDatabase = sQLiteDatabaseC;
                            try {
                                o.b("Find events by status exception", e);
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
            } catch (Exception e2) {
                e = e2;
                cursorRawQuery = null;
            } catch (Throwable th3) {
                th = th3;
                cursorRawQuery = null;
            }
        } catch (Exception e3) {
            e = e3;
            cursorRawQuery = null;
        } catch (Throwable th4) {
            th = th4;
            cursorRawQuery = null;
        }
        return arrayList;
    }

    public void a() {
        o.a("cleanOldData start", new Object[0]);
        f();
        e();
    }

    public boolean a(List<com.qq.gdt.action.f.a.a> list) throws Throwable {
        SQLiteDatabase sQLiteDatabaseC;
        boolean z;
        boolean z2 = false;
        try {
            try {
                sQLiteDatabaseC = c();
                try {
                    int iA = a(sQLiteDatabaseC);
                    if (iA >= 10) {
                        o.a("超过条数限制" + iA, new Object[0]);
                        Iterator<com.qq.gdt.action.f.a.a> it = list.iterator();
                        while (it.hasNext()) {
                            it.next().a(-1L);
                        }
                        a(sQLiteDatabaseC, (Cursor) null, true);
                        return false;
                    }
                    sQLiteDatabaseC.beginTransaction();
                    Iterator<com.qq.gdt.action.f.a.a> it2 = list.iterator();
                    while (true) {
                        if (!it2.hasNext()) {
                            z = true;
                            break;
                        }
                        com.qq.gdt.action.f.a.a next = it2.next();
                        long jInsert = sQLiteDatabaseC.insert("events", null, a(next));
                        if (jInsert < 0) {
                            z = false;
                            break;
                        }
                        next.a(jInsert);
                    }
                    if (z) {
                        sQLiteDatabaseC.setTransactionSuccessful();
                    }
                    a(sQLiteDatabaseC, (Cursor) null, true);
                    z2 = z;
                    if (!z2) {
                        Iterator<com.qq.gdt.action.f.a.a> it3 = list.iterator();
                        while (it3.hasNext()) {
                            it3.next().a(-1L);
                        }
                    }
                    return z2;
                } catch (Exception e) {
                    e = e;
                    o.b("Database add events exception.", e);
                    a(sQLiteDatabaseC, (Cursor) null, true);
                }
            } catch (Throwable th) {
                th = th;
                a((SQLiteDatabase) null, (Cursor) null, true);
                throw th;
            }
        } catch (Exception e2) {
            e = e2;
            sQLiteDatabaseC = null;
        } catch (Throwable th2) {
            th = th2;
            a((SQLiteDatabase) null, (Cursor) null, true);
            throw th;
        }
    }

    public synchronized int b(List<com.qq.gdt.action.f.a.a> list) {
        int iDelete;
        SQLiteDatabase sQLiteDatabaseC;
        iDelete = -1;
        try {
            try {
                sQLiteDatabaseC = c();
                try {
                    try {
                        String[] strArr = new String[list.size()];
                        StringBuilder sb = new StringBuilder();
                        sb.append("id").append(" IN ").append(" ( ");
                        for (int i = 0; i < list.size(); i++) {
                            strArr[i] = String.valueOf(list.get(i).a());
                            if (i == list.size() - 1) {
                                sb.append("?");
                            } else {
                                sb.append("?").append(", ");
                            }
                        }
                        sb.append(" ) ");
                        iDelete = sQLiteDatabaseC.delete("events", sb.toString(), strArr);
                        o.a("Deleted " + iDelete + " events by id list.", new Object[0]);
                    } catch (Exception e) {
                        e = e;
                        o.b("Database delete events by id list exception.", e);
                    }
                } catch (Throwable th) {
                    th = th;
                    a(sQLiteDatabaseC, (Cursor) null, false);
                    throw th;
                }
            } catch (Throwable th2) {
                throw th2;
            }
        } catch (Exception e2) {
            e = e2;
            sQLiteDatabaseC = null;
        } catch (Throwable th3) {
            th = th3;
            sQLiteDatabaseC = null;
            a(sQLiteDatabaseC, (Cursor) null, false);
            throw th;
        }
        a(sQLiteDatabaseC, (Cursor) null, false);
        return iDelete;
    }
}
