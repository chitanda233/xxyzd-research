package com.sigmob.sdk.videoplayer;

import android.content.Context;
import android.graphics.SurfaceTexture;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.FrameLayout;
import android.widget.RelativeLayout;
import com.czhj.sdk.logger.SigmobLog;
import java.util.Timer;
import java.util.TimerTask;

/* JADX INFO: loaded from: classes4.dex */
public class a extends RelativeLayout implements h {
    private static final String f = "a";
    private static final int v = 6000;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    i f3685a;
    Class b;
    l c;
    public g d;
    public d e;
    private ViewGroup g;
    private int h;
    private Timer i;
    private C0571a j;
    private boolean k;
    private boolean l;
    private final Handler m;
    private boolean n;
    private boolean o;
    private int p;
    private int q;
    private float r;
    private k s;
    private int t;
    private String u;
    private boolean w;

    /* JADX INFO: renamed from: com.sigmob.sdk.videoplayer.a$a, reason: collision with other inner class name */
    public class C0571a extends TimerTask {
        public C0571a() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a() {
            long currentPositionWhenPlaying = a.this.getCurrentPositionWhenPlaying();
            long duration = a.this.getDuration();
            if (a.this.s == null) {
                return;
            }
            a.this.s.a(currentPositionWhenPlaying, duration);
        }

        @Override // java.util.TimerTask, java.lang.Runnable
        public void run() {
            if (a.this.e == d.STATE_PLAYING || a.this.e == d.STATE_PAUSE) {
                a.this.post(new Runnable() { // from class: com.sigmob.sdk.videoplayer.a$a$$ExternalSyntheticLambda0
                    @Override // java.lang.Runnable
                    public final void run() {
                        this.f$0.a();
                    }
                });
            }
        }
    }

    public a(Context context) {
        super(context);
        this.e = d.STATE_IDLE;
        this.m = new Handler(Looper.getMainLooper()) { // from class: com.sigmob.sdk.videoplayer.a.1
            @Override // android.os.Handler
            public void handleMessage(Message msg) {
                if (msg.what != 6000 || a.this.k || a.this.l) {
                    return;
                }
                a.this.k = true;
                a.this.setState(d.STATE_BUFFERING_START);
            }
        };
        FrameLayout frameLayout = new FrameLayout(context);
        this.g = frameLayout;
        frameLayout.setBackgroundColor(-16777216);
        addView(this.g, new RelativeLayout.LayoutParams(-1, -1));
    }

    private void s() {
        try {
            i iVar = this.f3685a;
            if (iVar != null) {
                iVar.f();
            }
            Class cls = this.b;
            this.f3685a = cls == null ? new j(this) : (i) cls.getConstructor(a.class).newInstance(this);
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    public void a() {
        SigmobLog.d("startVideo [" + hashCode() + "] ");
        try {
            s();
        } catch (Throwable th) {
            th.printStackTrace();
        }
        Window windowC = c.c(getContext());
        if (windowC != null) {
            windowC.setFlags(16777216, 16777216);
            windowC.addFlags(128);
        }
        m();
        b();
    }

    public void a(int seek) {
        if (this.e != d.STATE_PAUSE && this.e != d.STATE_PREPARED && this.e != d.STATE_AUTO_COMPLETE && this.e != d.STATE_PLAYING) {
            this.h = seek;
            return;
        }
        i iVar = this.f3685a;
        if (iVar == null) {
            return;
        }
        iVar.a(seek);
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void a(int what, int extra) {
        this.t = what;
        this.u = "" + extra;
        setState(d.STATE_ERROR);
    }

    public void a(g videoPlayerDataSource, int screen) {
        this.d = videoPlayerDataSource;
        c();
    }

    public void b() {
        SigmobLog.d("onStatePreparing  [" + hashCode() + "] ");
        setState(d.STATE_PREPARING);
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void b(int what, int extra) {
        d dVar;
        SigmobLog.d("onInfo() called with: what = [" + what + "], extra = [" + extra + "]");
        if (what != 3) {
            if (what == 701) {
                dVar = d.STATE_BUFFERING_START;
            } else if (what != 702) {
                return;
            }
            setState(dVar);
        }
        if (!this.l) {
            this.l = true;
            this.m.removeMessages(6000);
        }
        if (!this.k) {
            return;
        } else {
            this.k = false;
        }
        dVar = d.STATE_BUFFERING_END;
        setState(dVar);
    }

    public void c() {
        SigmobLog.d("onStateNormal stat" + this.e + " [" + hashCode() + "] ");
        setState(d.STATE_NORMAL);
        i iVar = this.f3685a;
        if (iVar != null) {
            iVar.f();
        }
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void c(int width, int height) {
        this.p = height;
        this.q = width;
        SigmobLog.d("onVideoSizeChanged  [" + hashCode() + "] ");
        l lVar = this.c;
        if (lVar == null) {
            return;
        }
        float f2 = this.r;
        if (f2 != 0.0f) {
            lVar.setRotation(f2);
        }
        this.c.a(width, height);
    }

    public void d() {
        this.o = false;
        if (this.e == d.STATE_NORMAL || this.f3685a == null) {
            a();
            return;
        }
        if (this.e == d.STATE_PAUSE || this.e == d.STATE_BUFFERING_END || this.e == d.STATE_AUTO_COMPLETE || this.e == d.STATE_PREPARED) {
            this.f3685a.a();
            e();
        }
    }

    public void e() {
        SigmobLog.d("onStatePlaying  [" + hashCode() + "] ");
        if (this.e == d.STATE_PREPARED) {
            int i = this.h;
            if (i != 0) {
                this.f3685a.a(i);
                this.h = 0;
            }
            if (!this.l) {
                this.m.sendEmptyMessageDelayed(6000, com.alipay.sdk.m.y.c.f378a);
            }
        }
        setState(d.STATE_PLAYING);
        f();
    }

    public void f() {
        SigmobLog.d("startProgressTimer:  [" + hashCode() + "] ");
        l();
        this.i = new Timer();
        C0571a c0571a = new C0571a();
        this.j = c0571a;
        this.i.schedule(c0571a, 0L, 300L);
    }

    public boolean g() {
        return this.w;
    }

    public long getCurrentPositionWhenPlaying() {
        if (this.e != d.STATE_PLAYING && this.e != d.STATE_PAUSE) {
            return 0L;
        }
        try {
            return this.f3685a.g();
        } catch (IllegalStateException e) {
            com.sigmob.sdk.base.utils.k.f(f, "getCurrentPositionWhenPlaying: error = " + e.getMessage(), new Object[0]);
            return 0L;
        }
    }

    public long getDuration() {
        i iVar = this.f3685a;
        if (iVar == null) {
            return 0L;
        }
        try {
            long j = iVar.j();
            com.sigmob.sdk.base.utils.k.f(f, "getDuration: duration = " + j, new Object[0]);
            return j;
        } catch (Throwable th) {
            com.sigmob.sdk.base.utils.k.f(f, "getDuration: error = " + th.getMessage(), new Object[0]);
            return 0L;
        }
    }

    public int getErrorCode() {
        return this.t;
    }

    public String getErrorMessage() {
        return this.u;
    }

    public int getVideoHeight() {
        return this.p;
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public g getVideoPlayerDataSource() {
        return this.d;
    }

    public int getVideoWidth() {
        return this.q;
    }

    public void h() {
        SigmobLog.d("reset  [" + hashCode() + "] ");
        l();
        c();
        this.g.removeAllViews();
        Window windowC = c.c(getContext());
        if (windowC != null) {
            windowC.clearFlags(128);
        }
        i iVar = this.f3685a;
        if (iVar != null) {
            iVar.f();
        }
    }

    public void i() {
        setState(d.STATE_STOP);
        h();
    }

    public void j() {
        if (this.e == d.STATE_NORMAL || this.e == d.STATE_PREPARING || this.e == d.STATE_ERROR) {
            h();
        } else {
            if (this.e == d.STATE_PAUSE || this.f3685a == null) {
                return;
            }
            k();
            this.f3685a.d();
        }
    }

    public void k() {
        SigmobLog.i("onStatePause  [" + hashCode() + "] ");
        setState(d.STATE_PAUSE);
        f();
    }

    public void l() {
        Timer timer = this.i;
        if (timer != null) {
            timer.cancel();
            this.i = null;
        }
        C0571a c0571a = this.j;
        if (c0571a != null) {
            c0571a.cancel();
            this.j = null;
        }
    }

    public void m() {
        SigmobLog.d("addTextureView [" + hashCode() + "] ");
        l lVar = this.c;
        if (lVar != null) {
            this.g.removeView(lVar);
        }
        l lVar2 = new l(getContext().getApplicationContext());
        this.c = lVar2;
        lVar2.setSurfaceTextureListener(this.f3685a);
        this.g.addView(this.c, new FrameLayout.LayoutParams(-1, -1, 17));
    }

    public void n() {
        this.o = true;
        a();
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void o() {
        SigmobLog.d("onPrepared  [" + hashCode() + "] ");
        setState(d.STATE_PREPARED);
        setMute(this.n);
        if (this.o) {
            return;
        }
        SigmobLog.d("mediaInterface start");
        e();
        this.f3685a.a();
        this.o = false;
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
        SigmobLog.d("onAttachedToWindow");
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void p() {
        setState(d.STATE_AUTO_COMPLETE);
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void q() {
    }

    public void r() {
        this.s = null;
        h();
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void setBufferProgress(int percent) {
    }

    public void setLooping(boolean looping) {
        i iVar = this.f3685a;
        if (iVar == null) {
            return;
        }
        try {
            iVar.a(looping);
            this.w = looping;
        } catch (IllegalStateException e) {
            e.printStackTrace();
        }
    }

    public void setMute(boolean isMute) {
        this.n = isMute;
        i iVar = this.f3685a;
        if (iVar == null) {
            return;
        }
        iVar.a(isMute ? 0.0f : 1.0f);
    }

    public void setState(d state) {
        this.e = state;
        Context contextE = com.sigmob.sdk.b.e();
        if (state == d.STATE_PLAYING) {
            c.f(contextE);
        } else if (state == d.STATE_NORMAL || state == d.STATE_PAUSE || state == d.STATE_AUTO_COMPLETE || state == d.STATE_STOP) {
            c.g(contextE);
        }
        k kVar = this.s;
        if (kVar == null) {
            return;
        }
        kVar.a(state);
    }

    @Override // com.sigmob.sdk.videoplayer.h
    public void setSurfaceTexture(SurfaceTexture saved_surface) {
        l lVar = this.c;
        if (lVar == null) {
            return;
        }
        lVar.setSurfaceTexture(saved_surface);
    }

    public void setTextureViewContainer(ViewGroup textureViewContainer) {
        this.g = textureViewContainer;
    }

    public void setUp(String url) {
        a(new g(url, (String) null), 0);
    }

    public void setVideoPlayerStatusListener(k listener) {
        this.s = listener;
    }
}
