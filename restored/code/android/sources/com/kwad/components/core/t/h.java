package com.kwad.components.core.t;

import android.os.Handler;
import android.os.Looper;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private long Fy;
    private a alw;
    private long alu = 100;
    private long alv = 0;
    private boolean So = false;
    private Handler alx = new Handler(Looper.getMainLooper());
    private Runnable aly = new Runnable() { // from class: com.kwad.components.core.t.h.1
        @Override // java.lang.Runnable
        public final void run() {
            if (h.this.alx == null) {
                return;
            }
            if (h.this.So) {
                h.this.alx.postDelayed(this, h.this.alu / 2);
                return;
            }
            h.this.wW();
            if (h.this.alx != null) {
                h.this.alx.postDelayed(this, h.this.alu);
            }
        }
    };

    public interface a {
        void onProgress(long j, long j2);
    }

    public h(long j) {
        this.Fy = j;
    }

    public final void start() {
        Handler handler = this.alx;
        if (handler == null) {
            return;
        }
        handler.post(this.aly);
    }

    public final void stop() {
        Handler handler = this.alx;
        if (handler != null) {
            handler.removeCallbacks(this.aly);
            this.alx = null;
        }
    }

    public final void pause() {
        this.So = true;
    }

    public final void resume() {
        this.So = false;
    }

    public final void a(a aVar) {
        this.alw = aVar;
    }

    protected final void wW() {
        a aVar = this.alw;
        if (aVar != null) {
            long j = this.Fy;
            long j2 = j - this.alv;
            aVar.onProgress(j2, j);
            if (j2 <= 0) {
                stop();
            }
        }
        this.alv += this.alu;
    }
}
