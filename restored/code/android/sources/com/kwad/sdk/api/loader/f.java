package com.kwad.sdk.api.loader;

import android.content.Context;
import android.util.Log;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public class f implements Thread.UncaughtExceptionHandler {
    private static f aHZ;
    private Thread.UncaughtExceptionHandler aIa;
    private int aIb;
    private long aId;
    private Context mContext;
    private boolean DEBUG = false;
    private final AtomicBoolean aIc = new AtomicBoolean();

    public static f bm(Context context) {
        if (aHZ == null) {
            synchronized (f.class) {
                if (aHZ == null) {
                    aHZ = new f(context);
                }
            }
        }
        return aHZ;
    }

    private f(Context context) {
        this.mContext = context;
    }

    public final void setDefaultUncaughtExceptionHandler(Thread.UncaughtExceptionHandler uncaughtExceptionHandler) {
        if (uncaughtExceptionHandler != this) {
            this.aIa = uncaughtExceptionHandler;
        }
    }

    public final void de(int i) {
        this.aId = System.currentTimeMillis();
        this.aIb = i;
        if (this.DEBUG) {
            Log.d("test.chen", "startCheck:");
        }
    }

    public final void cancel() {
        if (this.DEBUG) {
            Log.d("test.chen", "AutoRevertHandler cancel:");
        }
        this.aIc.set(true);
    }

    @Override // java.lang.Thread.UncaughtExceptionHandler
    public void uncaughtException(Thread thread, Throwable th) {
        try {
            if (this.DEBUG) {
                Log.d("test.chen", "AutoRevertHandler uncaughtException, mStartCheckTime:" + this.aId + ",mMaxDuration:" + this.aIb + ",mIsCancel:" + this.aIc.get());
            }
            if (!this.aIc.get() && this.aId > 0 && System.currentTimeMillis() - this.aId <= this.aIb) {
                Boolean bool = (Boolean) com.kwad.sdk.api.c.g("filterStack", th);
                boolean zBooleanValue = bool != null ? bool.booleanValue() : true;
                Context context = this.mContext;
                if (context != null && zBooleanValue) {
                    b.a(context, i.aIh, true);
                }
            }
            Thread.UncaughtExceptionHandler uncaughtExceptionHandler = this.aIa;
            if (uncaughtExceptionHandler != null) {
                uncaughtExceptionHandler.uncaughtException(thread, th);
            }
        } catch (Throwable th2) {
            try {
                th2.printStackTrace();
                if (this.aIa != null) {
                }
            } finally {
                if (this.aIa != null) {
                    this.aIa.uncaughtException(thread, th);
                }
            }
        }
    }
}
