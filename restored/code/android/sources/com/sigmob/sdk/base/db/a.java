package com.sigmob.sdk.base.db;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.database.sqlite.SQLiteStatement;
import android.util.Log;
import com.czhj.sdk.common.Database.SQLiteBuider;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.utils.n;

/* JADX INFO: loaded from: classes3.dex */
public class a extends SQLiteOpenHelper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3209a = "ads";
    public static final String b = "file_reference";
    public static final String c = "trigger_insert";
    public static final String d = "trigger_delete";
    public static final String e = "tracks";
    public static final String f = "adload_event";
    public static final String g = "adload_cache_event";
    public static final String h = "adload_ready_event";
    public static final String i = "wind.db";
    public static final long j = -2;
    public static final long k = -1;
    private static final int l = 11;
    private static String m = "CREATE TABLE ads ( endcard_md5 text  ,video_md5 text  ,ad blob  ,ad_source_channel text  ,ad_type integer  ,create_time integer  ,crid text  ,load_id text  ,adTrackersMap blob  ,adslot_id text  ,camp_id text  ,request_id text , primary key ( crid ,adslot_id) ); \n";
    private static String n = "CREATE TRIGGER trigger_insert after insert on ads begin insert or replace into file_reference (crid,adslot_id,video_md5,endcard_md5) values(new.crid,new.adslot_id,new.video_md5,new.endcard_md5) ; end; \n";
    private static String o = "CREATE TRIGGER trigger_delete after delete on ads begin delete from file_reference where crid = old.crid  and adslot_id == old.adslot_id; end;\n";
    private static String p = "CREATE TABLE file_reference ( endcard_md5 blob  ,video_md5 blob  ,crid text  ,adslot_id text  , primary key ( crid ,adslot_id ) );\n";
    private static String q = "CREATE TABLE tracks ( id integer primary key AUTOINCREMENT ,retryNum integer   ,source text   ,event text   ,request_id text   ,url text   ,timestamp integer   );\n";
    private static String r = "CREATE TABLE adload_event ( id integer primary key AUTOINCREMENT , adslot_id text  , error_code integer ,timestamp integer  );\n";
    private static String s = "CREATE TABLE adload_cache_event (  adslot_id text primary key, media_request_count integer ,media_ready_count integer ,pre_req_time integer , req_interval_time integer ,req_pool_size integer); \n";
    private static String t = "CREATE TABLE adload_ready_event (  adslot_id text primary key, media_request_count integer ,media_ready_count integer ); \n";
    private static final long u = -6;
    private static final long v = -5;
    private static final long w = -4;
    private static final long x = 0;
    private static a y;
    private static SQLiteDatabase z;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.db.a$a, reason: collision with other inner class name */
    public interface InterfaceC0557a {
        void a();

        void a(Throwable e);
    }

    private a(final Context context) {
        super(context, i, (SQLiteDatabase.CursorFactory) null, 11);
    }

    private static long a(SQLiteDatabase db) {
        if (db == null) {
            return u;
        }
        if (!db.isOpen()) {
            return v;
        }
        if (db.isReadOnly()) {
            return w;
        }
        return 0L;
    }

    public static a a() {
        return y;
    }

    public static synchronized void a(final Context context) {
        if (y == null) {
            y = new a(context);
        }
    }

    private void a(final SQLiteDatabase database, final String field, final String table) {
        database.execSQL("alter table " + table + " drop column " + field);
    }

    private void a(final SQLiteDatabase database, final String field, final String type, final String table) {
        database.execSQL("alter table " + table + " add " + field + " " + type);
    }

    private void b(SQLiteDatabase database) {
        database.execSQL("DROP TABLE IF EXISTS ads");
        database.execSQL("DROP TABLE IF EXISTS file_reference");
        database.execSQL("DROP TABLE IF EXISTS tracks");
        database.execSQL("DROP TABLE IF EXISTS adload_event");
        database.execSQL("DROP TABLE IF EXISTS adload_cache_event");
        database.execSQL("DROP TABLE IF EXISTS adload_ready_event");
        database.execSQL("DROP TRIGGER IF EXISTS trigger_insert");
        database.execSQL("DROP TRIGGER IF EXISTS trigger_delete");
        n.i();
        onCreate(database);
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:8:0x002d A[Catch: all -> 0x007b, TryCatch #2 {all -> 0x007b, blocks: (B:3:0x0003, B:4:0x000d, B:6:0x0017, B:8:0x002d, B:21:0x0060, B:9:0x0031, B:11:0x0035, B:12:0x003b, B:14:0x003f, B:15:0x0049, B:17:0x004d, B:18:0x0057, B:20:0x005b, B:22:0x0063), top: B:56:0x0003 }] */
    public static /* synthetic */ void b(SQLiteDatabase sQLiteDatabase, SQLiteBuider.Insert insert, InterfaceC0557a interfaceC0557a) {
        boolean z2;
        sQLiteDatabase.beginTransaction();
        try {
            SQLiteStatement sQLiteStatementCompileStatement = sQLiteDatabase.compileStatement(insert.getSql());
            z2 = true;
            for (int i2 = 1; i2 <= insert.getColumns().size(); i2++) {
                Object obj = insert.getValues().get((String) insert.getColumns().get(i2 - 1));
                if (obj == null) {
                    sQLiteStatementCompileStatement.bindNull(i2);
                } else if (obj instanceof String) {
                    sQLiteStatementCompileStatement.bindString(i2, (String) obj);
                } else if (obj instanceof Double) {
                    sQLiteStatementCompileStatement.bindDouble(i2, ((Double) obj).doubleValue());
                } else if (obj instanceof Number) {
                    sQLiteStatementCompileStatement.bindLong(i2, ((Number) obj).longValue());
                } else if (obj instanceof byte[]) {
                    sQLiteStatementCompileStatement.bindBlob(i2, (byte[]) obj);
                } else {
                    sQLiteStatementCompileStatement.bindNull(i2);
                }
            }
            sQLiteStatementCompileStatement.execute();
            sQLiteDatabase.setTransactionSuccessful();
            try {
                sQLiteDatabase.endTransaction();
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
                if (interfaceC0557a != null) {
                    interfaceC0557a.a(th);
                }
            }
        } catch (Throwable th2) {
            try {
                SigmobLog.e(th2.getMessage());
                if (interfaceC0557a != null) {
                    interfaceC0557a.a(th2);
                }
                try {
                    sQLiteDatabase.endTransaction();
                } catch (Throwable th3) {
                    SigmobLog.e(th3.getMessage());
                    if (interfaceC0557a != null) {
                        interfaceC0557a.a(th3);
                    }
                }
                z2 = false;
            } finally {
                try {
                    sQLiteDatabase.endTransaction();
                } catch (Throwable th4) {
                    SigmobLog.e(th4.getMessage());
                    if (interfaceC0557a != null) {
                        interfaceC0557a.a(th4);
                    }
                }
            }
        }
        if (!z2 || interfaceC0557a == null) {
            return;
        }
        interfaceC0557a.a();
    }

    public void a(final SQLiteDatabase sqLiteDatabase, final SQLiteBuider.Insert insert, final InterfaceC0557a callBack) {
        ThreadPoolFactory.getFixIOExecutor().submit(new Runnable() { // from class: com.sigmob.sdk.base.db.a$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                a.b(sqLiteDatabase, insert, callBack);
            }
        });
    }

    public void a(SQLiteDatabase sqLiteDatabase, String sql, InterfaceC0557a callBack) {
        sqLiteDatabase.beginTransaction();
        boolean z2 = false;
        try {
            sqLiteDatabase.execSQL(sql, new Object[0]);
            sqLiteDatabase.setTransactionSuccessful();
            sqLiteDatabase.endTransaction();
            z2 = true;
        } catch (Throwable th) {
            try {
                SigmobLog.e(th.getMessage());
                if (callBack != null) {
                    callBack.a(th);
                }
                sqLiteDatabase.endTransaction();
            } catch (Throwable th2) {
                sqLiteDatabase.endTransaction();
                throw th2;
            }
        }
        if (!z2 || callBack == null) {
            return;
        }
        callBack.a();
    }

    public void b() {
        b(getWritableDatabase());
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onCreate(final SQLiteDatabase sqLiteDatabase) {
        sqLiteDatabase.execSQL(r);
        sqLiteDatabase.execSQL(s);
        sqLiteDatabase.execSQL(t);
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onDowngrade(SQLiteDatabase database, int oldVersion, int newVersion) {
        Log.w(a.class.getName(), "Downgrading database from version " + oldVersion + " to " + newVersion + ", which will destroy all old data");
        b(database);
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onOpen(SQLiteDatabase db) {
        super.onOpen(db);
        setWriteAheadLoggingEnabled(true);
    }

    @Override // android.database.sqlite.SQLiteOpenHelper
    public void onUpgrade(SQLiteDatabase database, int oldVersion, int newVersion) {
        Log.w(a.class.getName(), "Upgrading database from version " + oldVersion + " to " + newVersion + ", which will destroy all old data");
        b(database);
    }
}
