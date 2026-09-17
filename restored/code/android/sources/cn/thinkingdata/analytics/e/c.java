package cn.thinkingdata.analytics.e;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteOpenHelper;
import android.text.TextUtils;
import cn.thinkingdata.core.utils.TDLog;
import com.czhj.sdk.common.Constants;
import java.io.File;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class c {
    private static final String b = "CREATE TABLE " + EnumC0022c.EVENTS.a() + " (_id INTEGER PRIMARY KEY AUTOINCREMENT, clickdata TEXT NOT NULL, creattime INTEGER NOT NULL, token TEXT NOT NULL DEFAULT '')";
    private static final String c = "CREATE INDEX IF NOT EXISTS time_idx ON " + EnumC0022c.EVENTS.a() + " (creattime);";
    private static final Map<Context, c> d = new HashMap();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final a f93a;

    private static class a extends SQLiteOpenHelper {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final File f94a;
        private final int b;

        public a(Context context, String str) {
            super(context, str, (SQLiteDatabase.CursorFactory) null, 1);
            this.f94a = context.getDatabasePath(str);
            this.b = f.a(context).c();
        }

        boolean a() {
            return !this.f94a.exists() || b() < this.b;
        }

        /* JADX WARN: Code duplicated, block: B:14:0x003b A[DONT_GENERATE, PHI: r1 r2
  0x003b: PHI (r1v1 int) = (r1v0 int), (r1v3 int) binds: [B:13:0x0039, B:7:0x0030] A[DONT_GENERATE, DONT_INLINE]
  0x003b: PHI (r2v3 android.database.Cursor) = (r2v1 android.database.Cursor), (r2v4 android.database.Cursor) binds: [B:13:0x0039, B:7:0x0030] A[DONT_GENERATE, DONT_INLINE]] */
        int b() {
            int i = 0;
            Cursor cursorRawQuery = null;
            try {
                try {
                    cursorRawQuery = getReadableDatabase().rawQuery("SELECT count(*) FROM " + EnumC0022c.EVENTS.a(), null);
                    i = cursorRawQuery.moveToNext() ? cursorRawQuery.getInt(cursorRawQuery.getColumnIndex("count(*)")) : 0;
                } catch (Exception e) {
                    e.printStackTrace();
                }
                return i;
            } finally {
                if (cursorRawQuery != null) {
                    cursorRawQuery.close();
                }
            }
        }

        void c() {
            close();
            this.f94a.delete();
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onCreate(SQLiteDatabase sQLiteDatabase) {
            TDLog.d("ThinkingAnalytics.DatabaseAdapter", "Creating a new ThinkingData events database");
            sQLiteDatabase.execSQL(c.b);
            sQLiteDatabase.execSQL(c.c);
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
            TDLog.d("ThinkingAnalytics.DatabaseAdapter", "Upgrading ThinkingData events database");
            sQLiteDatabase.execSQL("DROP TABLE IF EXISTS " + EnumC0022c.EVENTS.a());
            sQLiteDatabase.execSQL(c.b);
            sQLiteDatabase.execSQL(c.c);
        }
    }

    private class b extends SQLiteOpenHelper {
        b(c cVar, Context context, String str) {
            super(context, str, (SQLiteDatabase.CursorFactory) null, 1);
        }

        /* JADX WARN: Code duplicated, block: B:17:0x0063 A[DONT_GENERATE, PHI: r4
  0x0063: PHI (r4v3 android.database.Cursor) = (r4v2 android.database.Cursor), (r4v4 android.database.Cursor) binds: [B:16:0x0061, B:9:0x0055] A[DONT_GENERATE, DONT_INLINE]] */
        JSONArray a() {
            JSONArray jSONArray = new JSONArray();
            Cursor cursorRawQuery = null;
            try {
                cursorRawQuery = getReadableDatabase().rawQuery("SELECT * FROM " + EnumC0022c.EVENTS + " ORDER BY ?", new String[]{"creattime"});
                while (cursorRawQuery.moveToNext()) {
                    JSONObject jSONObject = new JSONObject();
                    jSONObject.put("creattime", cursorRawQuery.getString(cursorRawQuery.getColumnIndex("creattime")));
                    jSONObject.put("clickdata", cursorRawQuery.getString(cursorRawQuery.getColumnIndex("clickdata")));
                    jSONArray.put(jSONObject);
                }
            } catch (Exception e) {
                e.printStackTrace();
            } finally {
                close();
                if (cursorRawQuery != null) {
                    cursorRawQuery.close();
                }
            }
            return jSONArray;
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onCreate(SQLiteDatabase sQLiteDatabase) {
        }

        @Override // android.database.sqlite.SQLiteOpenHelper
        public void onUpgrade(SQLiteDatabase sQLiteDatabase, int i, int i2) {
        }
    }

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.e.c$c, reason: collision with other inner class name */
    public enum EnumC0022c {
        EVENTS("events");


        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final String f95a;

        EnumC0022c(String str) {
            this.f95a = str;
        }

        public String a() {
            return this.f95a;
        }
    }

    c(Context context) {
        this(context, "thinkingdata");
    }

    c(Context context, String str) {
        this.f93a = new a(context, str);
        try {
            File databasePath = context.getDatabasePath(context.getPackageName());
            if (databasePath.exists()) {
                JSONArray jSONArrayA = new b(this, context, context.getPackageName()).a();
                for (int i = 0; i < jSONArrayA.length(); i++) {
                    try {
                        JSONObject jSONObject = jSONArrayA.getJSONObject(i);
                        ContentValues contentValues = new ContentValues();
                        contentValues.put("clickdata", jSONObject.getString("clickdata"));
                        contentValues.put("creattime", jSONObject.getString("creattime"));
                        TDLog.d("ThinkingAnalytics.DatabaseAdapter", contentValues.toString());
                        this.f93a.getWritableDatabase().insert(EnumC0022c.EVENTS.a(), null, contentValues);
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                }
                databasePath.delete();
            }
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    static c a(Context context) {
        c cVar;
        Map<Context, c> map = d;
        synchronized (map) {
            Context applicationContext = context.getApplicationContext();
            if (map.containsKey(applicationContext)) {
                cVar = map.get(applicationContext);
            } else {
                cVar = new c(applicationContext);
                map.put(applicationContext, cVar);
            }
        }
        return cVar;
    }

    private boolean c() {
        return this.f93a.a();
    }

    /* JADX WARN: Code duplicated, block: B:22:0x007e A[DONT_GENERATE, PHI: r3 r8
  0x007e: PHI (r3v3 android.database.Cursor) = (r3v1 android.database.Cursor), (r3v4 android.database.Cursor) binds: [B:21:0x007c, B:10:0x0059] A[DONT_GENERATE, DONT_INLINE]
  0x007e: PHI (r8v5 int) = (r8v3 int), (r8v9 int) binds: [B:21:0x007c, B:10:0x0059] A[DONT_GENERATE, DONT_INLINE]] */
    public int a(String str, EnumC0022c enumC0022c, String str2) {
        int i;
        String strA = enumC0022c.a();
        Cursor cursorRawQuery = null;
        try {
            SQLiteDatabase writableDatabase = this.f93a.getWritableDatabase();
            StringBuilder sb = new StringBuilder("_id <= ?");
            if (str2 != null) {
                sb.append(" AND token = ?");
            }
            writableDatabase.delete(strA, sb.toString(), new String[]{str, str2});
            StringBuilder sb2 = new StringBuilder("SELECT COUNT(*) FROM " + strA);
            if (str2 != null) {
                sb2.append(" WHERE token= ?");
            }
            cursorRawQuery = writableDatabase.rawQuery(sb2.toString(), new String[]{str2});
            cursorRawQuery.moveToFirst();
            i = cursorRawQuery.getInt(0);
        } catch (SQLiteException e) {
            TDLog.e("ThinkingAnalytics.DatabaseAdapter", "could not clean data from " + strA, e);
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
            this.f93a.c();
            i = -1;
        } finally {
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
        }
        return i;
    }

    /* JADX WARN: Code duplicated, block: B:29:0x00ce A[DONT_GENERATE, PHI: r5 r11
  0x00ce: PHI (r5v3 android.database.Cursor) = (r5v2 android.database.Cursor), (r5v4 android.database.Cursor) binds: [B:28:0x00cc, B:18:0x00a5] A[DONT_GENERATE, DONT_INLINE]
  0x00ce: PHI (r11v5 int) = (r11v4 int), (r11v18 int) binds: [B:28:0x00cc, B:18:0x00a5] A[DONT_GENERATE, DONT_INLINE]] */
    public int a(JSONObject jSONObject, EnumC0022c enumC0022c, String str) throws Throwable {
        int i;
        Cursor cursorRawQuery = null;
        if (!c()) {
            TDLog.d("ThinkingAnalytics.DatabaseAdapter", "The data has reached the limit, oldest data will be deleted");
            String[] strArrA = a(enumC0022c, (String) null, 100);
            if (strArrA == null || a(strArrA[0], EnumC0022c.EVENTS, (String) null) <= 0) {
                return -2;
            }
        }
        String strA = enumC0022c.a();
        try {
            SQLiteDatabase writableDatabase = this.f93a.getWritableDatabase();
            ContentValues contentValues = new ContentValues();
            if (cn.thinkingdata.analytics.encrypt.e.a(str) != null) {
                jSONObject = cn.thinkingdata.analytics.encrypt.e.a(str).a(jSONObject);
            }
            contentValues.put("clickdata", jSONObject.toString() + "#td#" + jSONObject.toString().hashCode());
            contentValues.put("creattime", Long.valueOf(System.currentTimeMillis()));
            contentValues.put(Constants.TOKEN, str);
            writableDatabase.insert(strA, null, contentValues);
            cursorRawQuery = writableDatabase.rawQuery("SELECT COUNT(*) FROM " + strA + " WHERE token=?", new String[]{str});
            cursorRawQuery.moveToFirst();
            i = cursorRawQuery.getInt(0);
        } catch (SQLiteException e) {
            TDLog.e("ThinkingAnalytics.DatabaseAdapter", "could not add data to table " + strA + ". Re-initializing database.", e);
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
            this.f93a.c();
            i = -1;
        } finally {
            if (cursorRawQuery != null) {
                cursorRawQuery.close();
            }
        }
        return i;
    }

    public void a(long j, EnumC0022c enumC0022c) {
        try {
            this.f93a.getWritableDatabase().delete(enumC0022c.a(), "creattime <= ?", new String[]{j + ""});
        } catch (SQLiteException e) {
            TDLog.e("ThinkingAnalytics.DatabaseAdapter", "Could not clean timed-out records. Re-initializing database.", e);
            this.f93a.c();
        }
    }

    public void a(EnumC0022c enumC0022c, String str) {
        try {
            this.f93a.getWritableDatabase().delete(enumC0022c.a(), "token = ?", new String[]{str});
        } catch (SQLiteException e) {
            TDLog.e("ThinkingAnalytics.DatabaseAdapter", "Could not clean records. Re-initializing database.", e);
            this.f93a.c();
        }
    }

    /* JADX WARN: Code duplicated, block: B:50:0x00f5 A[PHI: r3 r12 r14
  0x00f5: PHI (r3v2 java.lang.String) = (r3v1 java.lang.String), (r3v6 java.lang.String) binds: [B:49:0x00f3, B:40:0x00d2] A[DONT_GENERATE, DONT_INLINE]
  0x00f5: PHI (r12v9 java.lang.String) = (r12v8 java.lang.String), (r12v12 java.lang.String) binds: [B:49:0x00f3, B:40:0x00d2] A[DONT_GENERATE, DONT_INLINE]
  0x00f5: PHI (r14v3 android.database.Cursor) = (r14v2 android.database.Cursor), (r14v7 android.database.Cursor) binds: [B:49:0x00f3, B:40:0x00d2] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:59:0x0108  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r14v0, types: [int] */
    /* JADX WARN: Type inference failed for: r7v0 */
    /* JADX WARN: Type inference failed for: r7v1, types: [android.database.Cursor] */
    /* JADX WARN: Type inference failed for: r7v2 */
    public String[] a(EnumC0022c enumC0022c, String str, int i) throws Throwable {
        Cursor cursorRawQuery;
        String string;
        String string2;
        String strA = enumC0022c.a();
        ?? r7 = 0;
        try {
            try {
                SQLiteDatabase readableDatabase = this.f93a.getReadableDatabase();
                StringBuilder sb = new StringBuilder("SELECT * FROM ");
                sb.append(strA);
                if (str != null) {
                    sb.append(" WHERE token = ?");
                }
                sb.append(" ORDER BY ? ASC LIMIT ?");
                JSONArray jSONArray = new JSONArray();
                cursorRawQuery = readableDatabase.rawQuery(sb.toString(), new String[]{str, "creattime", ((int) i) + ""});
                if (cursorRawQuery != null) {
                    string2 = null;
                    while (cursorRawQuery.moveToNext()) {
                        try {
                            if (cursorRawQuery.isLast()) {
                                string2 = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("_id"));
                            }
                            try {
                                String string3 = cursorRawQuery.getString(cursorRawQuery.getColumnIndex("clickdata"));
                                if (!TextUtils.isEmpty(string3)) {
                                    int iLastIndexOf = string3.lastIndexOf("#td#");
                                    if (iLastIndexOf > -1) {
                                        String strReplaceFirst = string3.substring(iLastIndexOf).replaceFirst("#td#", "");
                                        string3 = string3.substring(0, iLastIndexOf);
                                        if (!TextUtils.isEmpty(string3) && !TextUtils.isEmpty(strReplaceFirst) && strReplaceFirst.equals(String.valueOf(string3.hashCode()))) {
                                        }
                                    }
                                    JSONObject jSONObject = new JSONObject(string3);
                                    cn.thinkingdata.analytics.encrypt.e eVarA = cn.thinkingdata.analytics.encrypt.e.a(str);
                                    if (eVarA != null && !cn.thinkingdata.analytics.encrypt.c.a(jSONObject)) {
                                        jSONObject = eVarA.a(jSONObject);
                                    }
                                    jSONArray.put(jSONObject);
                                }
                            } catch (JSONException unused) {
                            }
                        } catch (SQLiteException e) {
                            e = e;
                            TDLog.e("ThinkingAnalytics.DatabaseAdapter", "Could not pull records out of database " + strA, e);
                            string = null;
                            string2 = null;
                            if (cursorRawQuery != null) {
                                cursorRawQuery.close();
                            }
                        }
                    }
                    string = jSONArray.length() > 0 ? jSONArray.toString() : null;
                } else {
                    string = null;
                    string2 = null;
                }
                if (cursorRawQuery != null) {
                    cursorRawQuery.close();
                }
            } catch (Throwable th) {
                th = th;
                r7 = i;
                if (r7 != 0) {
                    r7.close();
                }
                throw th;
            }
        } catch (SQLiteException e2) {
            e = e2;
            cursorRawQuery = null;
        } catch (Throwable th2) {
            th = th2;
            if (r7 != 0) {
                r7.close();
            }
            throw th;
        }
        if (string2 == null || string == null) {
            return null;
        }
        return new String[]{string2, string};
    }
}
