package com.kwad.components.core.innerEc.live.b.c;

import android.os.Handler;
import android.os.Looper;
import android.os.SystemClock;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.ViewConfiguration;
import android.widget.RelativeLayout;
import com.kwad.components.core.innerEc.live.like.LikeResponse;
import com.kwad.components.core.innerEc.live.widget.PhotoSpeedControlFrameLayout;
import com.kwad.sdk.R;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends com.kwad.components.core.innerEc.live.b.a.a implements com.kwad.components.core.k.a {
    private RelativeLayout WN;
    private PhotoSpeedControlFrameLayout WO;
    private com.kwad.components.core.innerEc.live.widget.d WP;
    private GestureDetector.SimpleOnGestureListener WQ;
    private long WR;
    private boolean WS;
    private com.kwad.components.core.innerEc.live.like.b WT;
    private Runnable WX;
    private final List<Integer> WM = new ArrayList();
    private long WU = 1000;
    private int WV = 0;
    private final Handler WW = new Handler(Looper.getMainLooper());
    private volatile boolean WY = false;
    private final Object WZ = new Object();
    private final Runnable Xa = new Runnable() { // from class: com.kwad.components.core.innerEc.live.b.c.h.1
        @Override // java.lang.Runnable
        public final void run() {
            h.this.WP.G(com.kwad.components.core.innerEc.live.widget.d.Yw);
        }
    };
    private final com.kwad.components.core.k.a Xb = new com.kwad.components.core.k.a() { // from class: com.kwad.components.core.innerEc.live.b.c.h.2
    };
    private final com.kwad.components.core.innerEc.live.like.b.a Xc = new com.kwad.components.core.innerEc.live.like.b.a() { // from class: com.kwad.components.core.innerEc.live.b.c.h.5
        @Override // com.kwad.components.core.innerEc.live.like.b.a
        public final void a(LikeResponse likeResponse) {
            h.this.WU = likeResponse.likeIntervalMs;
            synchronized (h.this.WZ) {
                h.a(h.this, false);
                if (h.this.WV > 0) {
                    h.this.sH();
                }
            }
        }

        @Override // com.kwad.components.core.innerEc.live.like.b.a
        public final void sL() {
            synchronized (h.this.WZ) {
                h.a(h.this, false);
            }
        }
    };

    static /* synthetic */ boolean a(h hVar, boolean z) {
        hVar.WY = false;
        return false;
    }

    private void sB() {
        this.Uj.UJ.add(this.Xb);
    }

    private void sC() {
        this.WN.removeCallbacks(this.Xa);
        this.WP.G(com.kwad.components.core.innerEc.live.widget.d.Yw);
        this.Uj.UJ.remove(this.Xb);
        RelativeLayout relativeLayout = this.WN;
        if (relativeLayout != null) {
            relativeLayout.removeAllViews();
        }
    }

    private void sD() {
        if (this.WQ == null) {
            this.WQ = new GestureDetector.SimpleOnGestureListener() { // from class: com.kwad.components.core.innerEc.live.b.c.h.3
                @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnDoubleTapListener
                public final boolean onDoubleTap(MotionEvent motionEvent) {
                    return h.this.onDoubleTap(motionEvent);
                }

                @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnDoubleTapListener
                public final boolean onSingleTapConfirmed(MotionEvent motionEvent) {
                    return super.onSingleTapConfirmed(motionEvent);
                }

                @Override // android.view.GestureDetector.SimpleOnGestureListener, android.view.GestureDetector.OnGestureListener
                public final boolean onSingleTapUp(MotionEvent motionEvent) {
                    h.this.onSingleTapUp(motionEvent);
                    return super.onSingleTapUp(motionEvent);
                }
            };
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.WN = (RelativeLayout) findViewById(R.id.ksad_slide_play_like_image);
        this.WO = (PhotoSpeedControlFrameLayout) findViewById(R.id.ksad_video_container);
        sD();
        for (int i = -15; i < 15; i++) {
            this.WM.add(Integer.valueOf(i));
        }
        this.WO.setClickable(true);
        sF();
        sE();
    }

    private void sE() {
        this.WX = new Runnable() { // from class: com.kwad.components.core.innerEc.live.b.c.h.4
            @Override // java.lang.Runnable
            public final void run() {
                h.this.sI();
            }
        };
    }

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.WO.a(this.WP);
        this.WN.setVisibility(0);
        com.kwad.components.core.innerEc.live.like.b bVar = new com.kwad.components.core.innerEc.live.like.b(this.Uj.mAdTemplate);
        this.WT = bVar;
        bVar.a(this.Xc);
        sB();
    }

    private void sF() {
        if (this.WP == null) {
            if (this.WQ == null) {
                sD();
            }
            this.WP = new com.kwad.components.core.innerEc.live.widget.d(getContext(), this.WQ) { // from class: com.kwad.components.core.innerEc.live.b.c.h.6
                @Override // com.kwad.components.core.innerEc.live.widget.d, android.view.GestureDetector
                public final boolean onTouchEvent(MotionEvent motionEvent) {
                    if (motionEvent.getActionMasked() == 6) {
                        return h.this.g(motionEvent);
                    }
                    return super.onTouchEvent(motionEvent);
                }
            };
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        getRootView().setOnTouchListener(null);
        this.WN.setOnTouchListener(null);
        this.WO.b(this.WP);
        this.Uj.UJ.remove(this.Xb);
        this.WT.b(this.Xc);
        sJ();
        sC();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        RelativeLayout relativeLayout = this.WN;
        if (relativeLayout != null) {
            relativeLayout.removeCallbacks(this.Xa);
        }
        sJ();
    }

    private boolean d(float f, float f2) {
        this.WP.G(500L);
        this.WN.removeCallbacks(this.Xa);
        this.WN.postDelayed(this.Xa, 500L);
        if (this.Uj.Vc) {
            f(f, f2);
            sG();
        } else {
            this.Uj.Vc = true;
        }
        return true;
    }

    private boolean e(float f, float f2) {
        this.WR = SystemClock.elapsedRealtime();
        this.WS = true;
        return d(f, f2);
    }

    private void sG() {
        synchronized (this.WZ) {
            this.WV++;
            if (!this.WY) {
                sH();
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sH() {
        this.WW.removeCallbacks(this.WX);
        this.WW.postDelayed(this.WX, this.WU);
        this.WY = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sI() {
        synchronized (this.WZ) {
            int i = this.WV;
            if (i <= 0) {
                this.WY = false;
            } else {
                this.WV = 0;
                this.WT.aP(i);
            }
        }
    }

    private void sJ() {
        Runnable runnable = this.WX;
        if (runnable != null) {
            this.WW.removeCallbacks(runnable);
        }
        synchronized (this.WZ) {
            if (this.WV > 0) {
                sI();
            }
            this.WY = false;
        }
    }

    private void f(float f, float f2) {
        com.kwad.sdk.core.d.c.d("LiveLikePresenter", "playLikeImageViewAnimator: " + f + ", " + f2);
        if (this.Uj.UI != null) {
            this.Uj.UI.c(f, f2);
        }
        if (this.Uj.Vb != null) {
            this.Uj.Vb.a(new com.kwad.sdk.core.b() { // from class: com.kwad.components.core.innerEc.live.b.c.h.7
                @Override // com.kwad.sdk.core.b
                public final void parseJson(JSONObject jSONObject) {
                }

                @Override // com.kwad.sdk.core.b
                public final JSONObject toJson() {
                    return new JSONObject();
                }
            });
        }
    }

    private boolean sK() {
        return SystemClock.elapsedRealtime() - this.WR < ((long) ViewConfiguration.getJumpTapTimeout());
    }

    public final boolean onDoubleTap(MotionEvent motionEvent) {
        this.WR = SystemClock.elapsedRealtime();
        if (this.WS) {
            return true;
        }
        d(motionEvent.getX(), motionEvent.getY());
        return true;
    }

    public final boolean onSingleTapUp(MotionEvent motionEvent) {
        if (sK()) {
            return e(motionEvent.getX(), motionEvent.getY());
        }
        this.WS = false;
        return false;
    }

    public final boolean g(MotionEvent motionEvent) {
        int actionIndex = motionEvent.getActionIndex();
        if (sK()) {
            return e(motionEvent.getX(actionIndex), motionEvent.getY(actionIndex));
        }
        return false;
    }
}
