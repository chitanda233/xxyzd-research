package com.kwad.components.core.h;

import android.os.Handler;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements Runnable {
    private InterfaceC0429a Sq;
    private volatile Handler jc;
    private long Sn = 1000;
    private boolean So = true;
    private long Sp = 0;
    private float mSpeed = 1.0f;

    /* JADX INFO: renamed from: com.kwad.components.core.h.a$a, reason: collision with other inner class name */
    public interface InterfaceC0429a {
        void D(long j);
    }

    public a(Handler handler) {
        this.jc = handler;
    }

    public final void a(InterfaceC0429a interfaceC0429a) {
        this.Sq = interfaceC0429a;
    }

    public final void start() {
        this.So = false;
        if (this.jc != null) {
            this.jc.post(this);
        }
    }

    public final void pause() {
        this.So = true;
    }

    public final void resume() {
        this.So = false;
    }

    public final void stop() {
        if (this.jc != null) {
            this.jc.removeCallbacks(this);
        }
    }

    public final void destroy() {
        stop();
        this.jc = null;
    }

    public final void setSpeed(float f) {
        if (f > 0.0f) {
            this.mSpeed = f;
        }
    }

    @Override // java.lang.Runnable
    public final synchronized void run() {
        InterfaceC0429a interfaceC0429a;
        if (this.jc != null) {
            if (!this.So && (interfaceC0429a = this.Sq) != null) {
                interfaceC0429a.D(this.Sp);
                this.Sp += this.Sn;
            }
            if (this.jc != null) {
                this.jc.postDelayed(this, (long) (this.Sn / this.mSpeed));
            }
        }
    }
}
