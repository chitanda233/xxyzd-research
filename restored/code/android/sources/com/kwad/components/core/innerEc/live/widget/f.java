package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.graphics.PointF;
import android.util.DisplayMetrics;
import android.view.View;
import android.view.animation.DecelerateInterpolator;
import android.view.animation.Interpolator;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.LinearSmoothScroller;
import androidx.recyclerview.widget.RecyclerView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends LinearLayoutManager {
    private final RecyclerView YT;
    private boolean YU;
    private int YV;
    private int YW;
    private g YX;
    private boolean YY;
    private final Context mContext;
    private int maxHeight;

    public final boolean isAutoMeasureEnabled() {
        return false;
    }

    public final boolean supportsPredictiveItemAnimations() {
        return false;
    }

    public f(RecyclerView recyclerView) {
        super(recyclerView.getContext(), 1, false);
        this.YX = g.c.Zh;
        this.maxHeight = 0;
        this.YY = false;
        this.YT = recyclerView;
        this.mContext = recyclerView.getContext();
        setStackFromEnd(true);
    }

    public final void a(a aVar) {
        this.YU = aVar.YU;
        this.YV = aVar.Zc;
        this.YW = aVar.Zd;
        com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "updateComments, setLiveCommentScrollConfigmEnableNewSpeedStrategy" + this.YU + "mFastScrollSpeedPx" + this.YV + "mSlowScrollSpeedPx" + this.YW);
    }

    public final void b(g gVar) {
        com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "setScrollStrategyscrollStrategy" + gVar);
        this.YX = gVar;
    }

    public final g te() {
        return this.YX;
    }

    public final void aL(boolean z) {
        this.YY = z;
    }

    public final void smoothScrollToPosition(RecyclerView recyclerView, RecyclerView.State state, int i) {
        b bVar = new b(recyclerView.getContext());
        bVar.setTargetPosition(i);
        startSmoothScroll(bVar);
    }

    protected final int getExtraLayoutSpace(RecyclerView.State state) {
        if (this.YY) {
            if (this.maxHeight < getHeight()) {
                this.maxHeight = getHeight();
            }
            int i = this.maxHeight;
            return Math.max(i << 2, i);
        }
        return super.getExtraLayoutSpace(state);
    }

    public final void onLayoutChildren(RecyclerView.Recycler recycler, RecyclerView.State state) {
        try {
            super.onLayoutChildren(recycler, state);
        } catch (IllegalArgumentException e) {
            com.kwad.sdk.core.d.c.e("LiveCommentLinearLayoutManager", "onLayoutChildrenException", e);
            a(recycler);
            tf();
        }
    }

    private void a(RecyclerView.Recycler recycler) {
        a(this.YT.getItemAnimator());
        this.YT.stopScroll();
        this.YT.stopNestedScroll();
        detachAndScrapAttachedViews(recycler);
        removeAndRecycleAllViews(recycler);
        if (this.YT.getAdapter() != null) {
            RecyclerView recyclerView = this.YT;
            recyclerView.scrollToPosition(recyclerView.getAdapter().getItemCount() - 1);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(RecyclerView.ItemAnimator itemAnimator) {
        if (itemAnimator != null) {
            int i = 0;
            while (i < 10 && itemAnimator.isRunning()) {
                i++;
                try {
                    itemAnimator.endAnimations();
                } catch (IllegalArgumentException e) {
                    com.kwad.sdk.core.d.c.e("LiveCommentLinearLayoutManager", "resetRecyclerState, clearCount: " + i, e);
                }
            }
        }
    }

    private void tf() {
        this.YT.postDelayed(new Runnable() { // from class: com.kwad.components.core.innerEc.live.widget.f.1
            @Override // java.lang.Runnable
            public final void run() {
                if (f.this.YT.isComputingLayout()) {
                    return;
                }
                final RecyclerView.ItemAnimator itemAnimator = f.this.YT.getItemAnimator();
                f fVar = f.this;
                f.a(itemAnimator);
                f.this.YT.setItemAnimator((RecyclerView.ItemAnimator) null);
                f.this.requestLayout();
                f.this.YT.postDelayed(new Runnable() { // from class: com.kwad.components.core.innerEc.live.widget.f.1.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        f.this.YT.setItemAnimator(itemAnimator);
                    }
                }, 48L);
            }
        }, 32L);
    }

    class b extends LinearSmoothScroller {
        private final Interpolator Ze;

        b(Context context) {
            super(context);
            this.Ze = new a(this, (byte) 0);
        }

        public final PointF computeScrollVectorForPosition(int i) {
            return f.this.computeScrollVectorForPosition(i);
        }

        protected final int calculateTimeForScrolling(int i) {
            if (f.this.YX instanceof g.a) {
                return ((g.a) f.this.YX).tg();
            }
            if (!(f.this.YX instanceof g.d)) {
                if (!(f.this.YX instanceof g.f)) {
                    if (f.this.YU) {
                        return aV(i);
                    }
                    return aT(i);
                }
                return aW(i);
            }
            return aU(i);
        }

        /* JADX WARN: Code duplicated, block: B:15:0x0030 A[PHI: r0
  0x0030: PHI (r0v10 float) = (r0v7 float), (r0v8 float) binds: [B:14:0x002e, B:17:0x0036] A[DONT_GENERATE, DONT_INLINE]] */
        private int aT(int i) {
            if (f.this.YX instanceof g.e) {
                return super.calculateTimeForScrolling(i);
            }
            if (i == 0) {
                return 0;
            }
            if (i == 10000) {
                return 4000;
            }
            float fPx2dip = com.kwad.sdk.c.a.a.px2dip(f.this.mContext, i) / 26.0f;
            float f = 3.4f;
            if (fPx2dip < 3.4f) {
                fPx2dip = f;
            } else {
                f = 10.0f;
                if (fPx2dip > 10.0f) {
                    fPx2dip = f;
                }
            }
            return (int) (fPx2dip * 30.0f);
        }

        protected final int calculateTimeForDeceleration(int i) {
            if (f.this.YX instanceof g.a) {
                return 0;
            }
            if (!(f.this.YX instanceof g.d)) {
                if (!(f.this.YX instanceof g.f)) {
                    if (f.this.YU) {
                        return aV(i);
                    }
                    return super.calculateTimeForDeceleration(i);
                }
                return aW(i);
            }
            return aU(i);
        }

        private int aU(int i) {
            g gVar = f.this.YX;
            if (!c(gVar)) {
                return aX(i);
            }
            int iAY = ((g.d) gVar).aY(i);
            return iAY == 0 ? aX(i) : iAY;
        }

        private int aV(int i) {
            int iAX;
            if (i != 0) {
                if (f.this.YX instanceof g.b) {
                    iAX = (i * 1000) / com.kwad.sdk.c.a.a.a(f.this.mContext, 1000.0f);
                } else if (!(f.this.YX instanceof g.e)) {
                    if (f.this.YX instanceof g.c) {
                        iAX = f.this.YV == 0 ? super.calculateTimeForScrolling(i) : (i * 1000) / f.this.YV;
                    } else {
                        iAX = aX(i);
                    }
                } else {
                    iAX = f.this.YW == 0 ? super.calculateTimeForScrolling(i) : (i * 1000) / f.this.YW;
                }
                int iMax = Math.max(iAX, 10);
                com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "updateComments, calculateTimeForScrollingForNewStrategydx" + i + "adjustTime" + iMax + "time" + iAX);
                return iMax;
            }
            com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "updateComments, calculateTimeForScrollingForNewStrategy, dx == 0");
            return 0;
        }

        private int aW(int i) {
            if (i != 0) {
                int iTi = f.this.YX instanceof g.f ? ((g.f) f.this.YX).ti() : 0;
                int iAX = iTi == 0 ? aX(i) : (i * 1000) / iTi;
                int iMax = Math.max(iAX, 10);
                com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "updateComments, calculateTimeForScrollingForNewStrategydx" + i + "adjustTime" + iMax + "time" + iAX);
                return iMax;
            }
            com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "updateComments, calculateTimeForScrollingForOptimalStrategy, dx == 0");
            return 0;
        }

        private static boolean c(g gVar) {
            return gVar instanceof g.d;
        }

        private int aX(int i) {
            return Math.max(super.calculateTimeForScrolling(i), 10);
        }

        protected final float calculateSpeedPerPixel(DisplayMetrics displayMetrics) {
            if (f.this.YX instanceof g.e) {
                return 8.0f / displayMetrics.density;
            }
            return super.calculateSpeedPerPixel(displayMetrics);
        }

        protected final void onTargetFound(View view, RecyclerView.State state, RecyclerView.SmoothScroller.Action action) {
            int iCalculateDxToMakeVisible = calculateDxToMakeVisible(view, getHorizontalSnapPreference());
            int iCalculateDyToMakeVisible = calculateDyToMakeVisible(view, getVerticalSnapPreference());
            if (f.this.YX instanceof g.a) {
                int iTg = ((g.a) f.this.YX).tg();
                if (iTg <= 1) {
                    iTg = 300;
                }
                action.update(-iCalculateDxToMakeVisible, -iCalculateDyToMakeVisible, iTg, new com.kwad.components.core.innerEc.live.widget.b(0.42f, 0.0f, 0.58f, 1.0f));
                return;
            }
            int iCalculateTimeForDeceleration = calculateTimeForDeceleration((int) Math.sqrt((iCalculateDxToMakeVisible * iCalculateDxToMakeVisible) + (iCalculateDyToMakeVisible * iCalculateDyToMakeVisible)));
            if (iCalculateTimeForDeceleration > 0) {
                action.update(-iCalculateDxToMakeVisible, -iCalculateDyToMakeVisible, iCalculateTimeForDeceleration, c(f.this.YX) ? this.Ze : this.mDecelerateInterpolator);
            }
        }

        class a implements Interpolator {
            private final Interpolator Zf;

            private a() {
                this.Zf = new DecelerateInterpolator();
            }

            /* synthetic */ a(b bVar, byte b) {
                this();
            }

            @Override // android.animation.TimeInterpolator
            public final float getInterpolation(float f) {
                g gVar = f.this.YX;
                if (!(gVar instanceof g.d)) {
                    return f(f);
                }
                List<k> listTh = ((g.d) gVar).th();
                if (!g.n(listTh)) {
                    return f(f);
                }
                try {
                    return a(f, listTh);
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.i("LiveCommentLinearLayoutManager", "calculateSegmentInterpolation error" + e);
                    return f(f);
                }
            }

            private float f(float f) {
                return b.this.mDecelerateInterpolator.getInterpolation(f);
            }

            private float a(float f, List<k> list) {
                k next;
                Iterator<k> it = list.iterator();
                float fTs = 0.0f;
                float fTt = 0.0f;
                while (true) {
                    if (!it.hasNext()) {
                        next = null;
                        break;
                    }
                    next = it.next();
                    if (f - fTs <= next.ts()) {
                        break;
                    }
                    fTs += next.ts();
                    fTt += next.tt();
                }
                if (next == null) {
                    return f;
                }
                return fTt + (this.Zf.getInterpolation((f - fTs) / next.ts()) * next.tt());
            }
        }
    }

    public static class a {
        private boolean YU = true;
        private int Zc = MediaPlayer.MEDIA_PLAYER_OPTION_TT_HLS_DRM;
        private int Zd = 200;

        public a(boolean z, int i, int i2) {
        }
    }
}
