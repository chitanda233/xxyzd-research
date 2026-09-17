package a.e.a;

import android.content.ContentResolver;
import android.content.Context;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.Looper;
import android.os.Message;
import android.os.SystemClock;

/* JADX INFO: loaded from: classes.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static Context f28a = null;
    public static boolean b = false;
    public static c c;
    public static c d;
    public static c e;
    public static Object f = new Object();
    public static HandlerThread g;
    public static Handler h;
    public static String i;
    public static String j;
    public static String k;
    public static volatile b l;
    public static volatile a.e.a.a m;

    public static class a extends Handler {
        public a(Looper looper) {
            super(looper);
        }

        @Override // android.os.Handler
        public void handleMessage(Message message) throws Throwable {
            if (message.what == 11) {
                int i = message.getData().getInt("type");
                try {
                    String strA = b.m.a(i, message.getData().getString("appid"));
                    if (i == 0) {
                        b.i = strA;
                    } else if (i != 1) {
                        if (i == 2 && strA != null) {
                            b.k = strA;
                        }
                    } else if (strA != null) {
                        b.j = strA;
                    }
                } catch (Exception e) {
                    String str = "readException:" + e.toString();
                }
                synchronized (b.f) {
                    b.f.notify();
                }
            }
        }
    }

    public b() {
        a();
        m = new a.e.a.a(f28a);
    }

    public static b a(Context context) {
        if (!b()) {
            return null;
        }
        if (f28a == null) {
            if (context == null) {
                return null;
            }
            Context applicationContext = context.getApplicationContext();
            if (applicationContext != null) {
                context = applicationContext;
            }
            f28a = context;
        }
        if (l == null) {
            synchronized (b.class) {
                if (l == null) {
                    l = new b();
                }
            }
        }
        return l;
    }

    public static void a() {
        HandlerThread handlerThread = new HandlerThread("SqlWorkThread");
        g = handlerThread;
        handlerThread.start();
        h = new a(g.getLooper());
    }

    public static synchronized void a(Context context, int i2, String str) {
        ContentResolver contentResolver;
        Uri uri;
        c cVar;
        String packageName = context.getPackageName();
        if (i2 != 0) {
            if (i2 != 1) {
                if (i2 == 2 && e == null) {
                    int i3 = Build.VERSION.SDK_INT;
                    if (i3 >= 29) {
                        e = new c(l, 2, packageName);
                        contentResolver = context.getContentResolver();
                        uri = Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/" + packageName);
                        cVar = e;
                    } else if (i3 == 28) {
                        e = new c(l, 2, str);
                        contentResolver = context.getContentResolver();
                        uri = Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/AAID_" + str);
                        cVar = e;
                    }
                    contentResolver.registerContentObserver(uri, false, cVar);
                }
            } else if (d == null) {
                int i4 = Build.VERSION.SDK_INT;
                if (i4 >= 29) {
                    d = new c(l, 1, packageName);
                    contentResolver = context.getContentResolver();
                    uri = Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/VAID_" + packageName);
                    cVar = d;
                } else if (i4 == 28) {
                    d = new c(l, 1, str);
                    contentResolver = context.getContentResolver();
                    uri = Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/VAID_" + str);
                    cVar = d;
                }
                contentResolver.registerContentObserver(uri, false, cVar);
            }
        } else if (c == null) {
            c = new c(l, 0, null);
            context.getContentResolver().registerContentObserver(Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/OAID"), true, c);
        }
    }

    public static boolean b() {
        String str = "0";
        if (!b && Build.VERSION.SDK_INT >= 28) {
            try {
                Class<?> cls = Class.forName("android.os.SystemProperties");
                str = (String) cls.getMethod("get", String.class, String.class).invoke(cls, com.alipay.sdk.m.u0.c.c, "0");
            } catch (Throwable unused) {
            }
            b = "1".equals(str);
        }
        return b;
    }

    public final void a(int i2, String str) {
        synchronized (f) {
            b(i2, str);
            SystemClock.uptimeMillis();
            try {
                f.wait(2000L);
            } catch (InterruptedException unused) {
            }
            SystemClock.uptimeMillis();
        }
    }

    public void b(int i2, String str) {
        Message messageObtainMessage = h.obtainMessage();
        messageObtainMessage.what = 11;
        Bundle bundle = new Bundle();
        bundle.putInt("type", i2);
        if (i2 == 1 || i2 == 2) {
            bundle.putString("appid", str);
        }
        messageObtainMessage.setData(bundle);
        h.sendMessage(messageObtainMessage);
    }
}
