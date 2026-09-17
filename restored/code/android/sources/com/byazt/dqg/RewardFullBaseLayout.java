package com.byazt.dqg;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.view.MotionEvent;
import android.widget.FrameLayout;
import com.byazt.aas.pf;
import com.byazt.ff.TTProgressBar;
import com.byazt.nr.z;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 74, 1127})
public class RewardFullBaseLayout extends FrameLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public FrameLayout f801a;
    public TTProgressBar c;
    public FrameLayout da;
    public FrameLayout i;
    public int m;
    public c n;
    public int nu;
    public FrameLayout sl;
    public FrameLayout sp;
    public FrameLayout t;
    public TTProgressBar tt;
    public FrameLayout u;
    public long uj;
    public float ve;
    public FrameLayout x;
    public int yp;
    public int z;

    public interface c {
        void c();
    }

    public RewardFullBaseLayout(Context context) {
        super(context);
    }

    public void c(com.byazt.fcd.c cVar) {
        FrameLayout frameLayoutN = n();
        this.f801a = frameLayoutN;
        frameLayoutN.setPadding(this.yp, this.z, this.m, this.nu);
        this.f801a.setClipChildren(false);
        this.f801a.addView(tt());
        this.f801a.addView(ve());
        this.f801a.addView(uj());
        addView(this.f801a);
        this.sp.addView(cVar.i());
        this.i.addView(cVar.da());
        this.da.addView(cVar.sl());
    }

    private FrameLayout tt() {
        this.u = n();
        FrameLayout frameLayoutN = n();
        this.t = frameLayoutN;
        this.u.addView(frameLayoutN);
        FrameLayout frameLayoutN2 = n();
        this.sp = frameLayoutN2;
        frameLayoutN2.setVisibility(8);
        this.t.addView(this.sp);
        FrameLayout frameLayoutN3 = n();
        this.x = frameLayoutN3;
        frameLayoutN3.setVisibility(8);
        this.t.addView(this.x);
        this.sl = n();
        return this.u;
    }

    private FrameLayout ve() {
        FrameLayout frameLayoutN = n();
        this.i = frameLayoutN;
        return frameLayoutN;
    }

    private FrameLayout uj() {
        FrameLayout frameLayoutN = n();
        this.da = frameLayoutN;
        return frameLayoutN;
    }

    private FrameLayout n() {
        FrameLayout frameLayout = new FrameLayout(getContext());
        frameLayout.setLayoutParams(new FrameLayout.LayoutParams(-1, -1));
        return frameLayout;
    }

    public FrameLayout getExpressFrameContainer() {
        return this.x;
    }

    public FrameLayout getEndCardFrameContainer() {
        return this.i;
    }

    public FrameLayout getWidgetFrameContainer() {
        return this.sp;
    }

    public FrameLayout getTopFrameContainer() {
        return this.da;
    }

    public FrameLayout getSceneFrame() {
        return this.t;
    }

    public FrameLayout getSceneFrameContainer() {
        return this.u;
    }

    public FrameLayout getEasyPlayableContainer() {
        return this.sl;
    }

    public void c(int i) {
        if (this.c == null) {
            this.c = new TTProgressBar(getContext());
            FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(120, 120);
            layoutParams.gravity = 17;
            this.c.setLayoutParams(layoutParams);
            try {
                z.c(getContext(), "tt_normalscreen_loading", new com.byazt.qr.c<Bitmap>() { // from class: com.byazt.dqg.RewardFullBaseLayout.1
                    @Override // com.byazt.qr.c
                    public void c(Bitmap bitmap) {
                        RewardFullBaseLayout.this.c.setIndeterminateDrawable(com.byazt.vfu.n.c(RewardFullBaseLayout.this.getContext(), new BitmapDrawable(RewardFullBaseLayout.this.getContext().getResources(), bitmap), 0, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_DEMUXER_STALL, 0.5f, 0.5f));
                    }
                }, MediaPlayer.MEDIA_PLAYER_OPTION_LAST_VIDEO_RENDER_TIME);
            } catch (Throwable unused) {
            }
            addView(this.c);
        }
        this.c.setVisibility(i);
    }

    public void c(int i, TTProgressBar tTProgressBar) {
        TTProgressBar tTProgressBar2 = this.tt;
        if (tTProgressBar2 != null) {
            tTProgressBar2.setVisibility(8);
            removeView(this.tt);
        }
        if (tTProgressBar == null) {
            return;
        }
        this.tt = tTProgressBar;
        addView(tTProgressBar);
        this.tt.setVisibility(i);
    }

    @Override // android.view.ViewGroup
    public boolean onInterceptTouchEvent(MotionEvent motionEvent) {
        if (this.n == null) {
            return super.onInterceptTouchEvent(motionEvent);
        }
        int action = motionEvent.getAction();
        if (action == 0) {
            this.ve = motionEvent.getY();
            this.uj = System.currentTimeMillis();
        } else if (action == 1) {
            float y = motionEvent.getY();
            float f = this.ve;
            if (y < f && Math.abs(y - f) > pf.ve(getContext(), 30.0f)) {
                this.n.c();
                return true;
            }
        }
        return super.onInterceptTouchEvent(motionEvent);
    }

    public void c(c cVar) {
        this.n = cVar;
    }

    public void c() {
        this.n = null;
    }

    public void c(int i, int i2, int i3, int i4) {
        this.yp = i;
        this.z = i2;
        this.m = i3;
        this.nu = i4;
    }
}
