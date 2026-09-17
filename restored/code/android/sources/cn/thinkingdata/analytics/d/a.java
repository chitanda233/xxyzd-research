package cn.thinkingdata.analytics.d;

import android.content.Context;
import android.content.res.Resources;
import android.os.Process;
import cn.thinkingdata.analytics.TDPresetProperties;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.crash.CrashLogListener;
import cn.thinkingdata.analytics.h.g;
import cn.thinkingdata.analytics.h.l;
import cn.thinkingdata.core.utils.TDLog;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.io.StringWriter;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.Arrays;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class a {
    private static a c;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f77a;
    private boolean b;

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.d.a$a, reason: collision with other inner class name */
    class C0014a implements CrashLogListener {

        /* JADX INFO: renamed from: cn.thinkingdata.analytics.d.a$a$a, reason: collision with other inner class name */
        class C0015a implements ThinkingAnalyticsSDK.n {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            final /* synthetic */ String f78a;
            final /* synthetic */ File b;

            C0015a(C0014a c0014a, String str, File file) {
                this.f78a = str;
                this.b = file;
            }

            @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
            public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
                if (thinkingAnalyticsSDK.shouldTrackCrash()) {
                    try {
                        JSONObject jSONObject = new JSONObject();
                        try {
                            if (this.f78a.getBytes("UTF-8").length > 16384) {
                                if (!TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                    jSONObject.put("#app_crashed_reason", new String(g.a(this.f78a, 16384), "UTF-8"));
                                }
                            } else if (!TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                jSONObject.put("#app_crashed_reason", this.f78a);
                            }
                        } catch (UnsupportedEncodingException unused) {
                            if (this.f78a.length() > 8192 && !TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                jSONObject.put("#app_crashed_reason", this.f78a.substring(0, 8192));
                            }
                        }
                        thinkingAnalyticsSDK.trackAppCrashAndEndEvent(jSONObject);
                        this.b.delete();
                    } catch (JSONException unused2) {
                    }
                }
            }
        }

        C0014a(a aVar) {
        }

        @Override // cn.thinkingdata.analytics.crash.CrashLogListener
        public void onFile(File file) {
            ThinkingAnalyticsSDK.allInstances(new C0015a(this, a.a(file), file));
        }
    }

    class b implements Runnable {
        b() {
        }

        @Override // java.lang.Runnable
        public void run() {
            a aVar = a.this;
            aVar.a(aVar.f77a);
        }
    }

    class c implements CrashLogListener {

        /* JADX INFO: renamed from: cn.thinkingdata.analytics.d.a$c$a, reason: collision with other inner class name */
        class C0016a implements ThinkingAnalyticsSDK.n {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            final /* synthetic */ String f80a;
            final /* synthetic */ File b;

            C0016a(c cVar, String str, File file) {
                this.f80a = str;
                this.b = file;
            }

            @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
            public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
                if (thinkingAnalyticsSDK.shouldTrackCrash()) {
                    try {
                        JSONObject jSONObject = new JSONObject();
                        try {
                            if (this.f80a.getBytes("UTF-8").length > 16384) {
                                if (!TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                    jSONObject.put("#app_crashed_reason", new String(g.a(this.f80a, 16384), "UTF-8"));
                                }
                            } else if (!TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                jSONObject.put("#app_crashed_reason", this.f80a);
                            }
                        } catch (UnsupportedEncodingException unused) {
                            if (this.f80a.length() > 8192 && !TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                jSONObject.put("#app_crashed_reason", this.f80a.substring(0, 8192));
                            }
                        }
                        thinkingAnalyticsSDK.autoTrack("ta_app_crash", jSONObject);
                        this.b.delete();
                    } catch (JSONException unused2) {
                    }
                }
            }
        }

        c(a aVar) {
        }

        @Override // cn.thinkingdata.analytics.crash.CrashLogListener
        public void onFile(File file) {
            ThinkingAnalyticsSDK.allInstances(new C0016a(this, a.a(file), file));
        }
    }

    private static class d implements Thread.UncaughtExceptionHandler {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final Thread.UncaughtExceptionHandler f81a = Thread.getDefaultUncaughtExceptionHandler();

        /* JADX INFO: renamed from: cn.thinkingdata.analytics.d.a$d$a, reason: collision with other inner class name */
        class C0017a implements ThinkingAnalyticsSDK.n {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            final /* synthetic */ String f82a;

            C0017a(d dVar, String str) {
                this.f82a = str;
            }

            @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
            public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
                if (thinkingAnalyticsSDK.shouldTrackCrash()) {
                    try {
                        JSONObject jSONObject = new JSONObject();
                        try {
                            if (this.f82a.getBytes("UTF-8").length > 16384) {
                                if (!TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                    jSONObject.put("#app_crashed_reason", new String(g.a(this.f82a, 16384), "UTF-8"));
                                }
                            } else if (!TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                jSONObject.put("#app_crashed_reason", this.f82a);
                            }
                        } catch (UnsupportedEncodingException unused) {
                            TDLog.d("ThinkingAnalytics.ExceptionHandler", "Exception occurred in getBytes. ");
                            if (this.f82a.length() > 8192 && !TDPresetProperties.disableList.contains("#app_crashed_reason")) {
                                jSONObject.put("#app_crashed_reason", this.f82a.substring(0, 8192));
                            }
                        }
                        thinkingAnalyticsSDK.trackAppCrashAndEndEvent(jSONObject);
                    } catch (JSONException unused2) {
                    }
                }
            }
        }

        d() {
            Thread.setDefaultUncaughtExceptionHandler(this);
        }

        private void a() {
            Process.killProcess(Process.myPid());
            System.exit(10);
        }

        private void a(Throwable th) {
            StringWriter stringWriter = new StringWriter();
            PrintWriter printWriter = new PrintWriter(stringWriter);
            do {
                th.printStackTrace(printWriter);
                th = th.getCause();
            } while (th != null);
            printWriter.close();
            ThinkingAnalyticsSDK.allInstances(new C0017a(this, stringWriter.toString().replaceAll("(\r\n|\n\r|\n|\r)", "<br>")));
        }

        @Override // java.lang.Thread.UncaughtExceptionHandler
        public void uncaughtException(Thread thread, Throwable th) {
            boolean z;
            Throwable cause = th;
            while (true) {
                if (cause == null) {
                    z = true;
                    break;
                } else {
                    if (cause instanceof l) {
                        z = false;
                        break;
                    }
                    cause = cause.getCause();
                }
            }
            if (z) {
                a(th);
                try {
                    Thread.sleep(1000L);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
            Thread.UncaughtExceptionHandler uncaughtExceptionHandler = this.f81a;
            if (uncaughtExceptionHandler != null) {
                uncaughtExceptionHandler.uncaughtException(thread, th);
            } else {
                a();
            }
        }
    }

    private a(Context context) {
        this.f77a = context.getApplicationContext();
    }

    static String a(File file) throws Throwable {
        StringBuffer stringBuffer = new StringBuffer();
        BufferedReader bufferedReader = null;
        try {
            try {
                BufferedReader bufferedReader2 = new BufferedReader(new FileReader(file));
                while (true) {
                    try {
                        String line = bufferedReader2.readLine();
                        if (line == null) {
                            break;
                        }
                        stringBuffer.append(line);
                        stringBuffer.append("\n");
                    } catch (IOException e) {
                        e = e;
                        bufferedReader = bufferedReader2;
                        e.printStackTrace();
                        if (bufferedReader != null) {
                            try {
                                bufferedReader.close();
                            } catch (IOException e2) {
                                e2.printStackTrace();
                            }
                        }
                        return stringBuffer.toString();
                    } catch (Throwable th) {
                        th = th;
                        bufferedReader = bufferedReader2;
                        if (bufferedReader != null) {
                            try {
                                bufferedReader.close();
                            } catch (IOException e3) {
                                e3.printStackTrace();
                            }
                        }
                        throw th;
                    }
                }
                bufferedReader2.close();
                String string = stringBuffer.toString();
                try {
                    bufferedReader2.close();
                } catch (IOException e4) {
                    e4.printStackTrace();
                }
                return string;
            } catch (IOException e5) {
                e = e5;
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(Context context) {
        File[] fileArrListFiles;
        String str = context.getCacheDir().getAbsolutePath() + File.separator + "tacrash";
        c cVar = new c(this);
        File file = new File(str);
        if (!file.exists() || (fileArrListFiles = file.listFiles()) == null) {
            return;
        }
        for (File file2 : fileArrListFiles) {
            cVar.onFile(file2);
        }
    }

    public static a b(Context context) {
        if (c == null) {
            if (context == null) {
                return null;
            }
            synchronized (d.class) {
                if (c == null) {
                    c = new a(context);
                }
            }
        }
        return c;
    }

    public synchronized void a() {
        if (!this.b) {
            ArrayList arrayList = new ArrayList();
            try {
                Resources resources = this.f77a.getResources();
                arrayList.addAll(Arrays.asList(resources.getStringArray(resources.getIdentifier("TACrashConfig", "array", this.f77a.getPackageName()))));
            } catch (Exception unused) {
            }
            if (arrayList.isEmpty()) {
                new d();
            } else {
                C0014a c0014a = new C0014a(this);
                new Thread(new b()).start();
                try {
                    Class<?> cls = Class.forName("cn.thinkingdata.android.crash.TACrash");
                    Object objInvoke = cls.getMethod("getInstance", new Class[0]).invoke(null, new Object[0]);
                    cls.getMethod("init", Context.class).invoke(objInvoke, this.f77a);
                    cls.getMethod("enableLog", new Class[0]).invoke(objInvoke, new Object[0]);
                    if (arrayList.contains("java")) {
                        cls.getMethod("initJavaCrashHandler", Boolean.TYPE).invoke(objInvoke, true);
                    }
                    if (arrayList.contains("anr") || arrayList.contains("native")) {
                        cls.getMethod("initNativeCrashHandler", Boolean.TYPE, Boolean.TYPE, Boolean.TYPE, Boolean.TYPE).invoke(objInvoke, true, true, true, true);
                        if (arrayList.contains("anr")) {
                            cls.getMethod("initANRHandler", new Class[0]).invoke(objInvoke, new Object[0]);
                        }
                    }
                    cls.getMethod("initCrashLogListener", CrashLogListener.class).invoke(objInvoke, c0014a);
                } catch (Exception unused2) {
                }
            }
            this.b = true;
        }
    }
}
