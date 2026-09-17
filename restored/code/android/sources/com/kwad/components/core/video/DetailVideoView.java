package com.kwad.components.core.video;

import android.animation.ValueAnimator;
import android.content.Context;
import android.graphics.Matrix;
import android.graphics.RectF;
import android.graphics.SurfaceTexture;
import android.util.AttributeSet;
import android.view.Surface;
import android.view.TextureView;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.FrameLayout;
import android.widget.TextView;
import androidx.core.internal.view.SupportMenu;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.PhotoInfo;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public class DetailVideoView extends KSFrameLayout implements View.OnClickListener {
    public com.kwad.components.core.page.widget.b ana;
    private b anb;
    private SurfaceTexture anc;
    private TextView and;
    public Surface ane;
    private a anf;
    private PhotoInfo.VideoInfo ang;
    private boolean anh;
    private final RectF ani;
    private int anj;
    private int ank;
    private long anl;
    private final d anm;
    private Matrix mMatrix;

    public interface a {
        void onClickRootView();

        void onClickVideoView();
    }

    public DetailVideoView(Context context) {
        super(context);
        this.anh = false;
        this.ani = new RectF();
        this.anj = 0;
        this.ank = 0;
        this.anl = 0L;
        this.anm = new d();
        B(context);
    }

    public DetailVideoView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.anh = false;
        this.ani = new RectF();
        this.anj = 0;
        this.ank = 0;
        this.anl = 0L;
        this.anm = new d();
        B(context);
    }

    private void B(Context context) {
        this.mMatrix = new Matrix();
        this.ana = new com.kwad.components.core.page.widget.b(context);
        addView(this.ana, 0, new FrameLayout.LayoutParams(-1, -1, 17));
        xG();
    }

    public void setIsAlphaVideoView(boolean z) {
        com.kwad.components.core.page.widget.b bVar;
        this.anh = z;
        if (!z || (bVar = this.ana) == null) {
            return;
        }
        bVar.setOpaque(false);
    }

    private void xG() {
        com.kwad.components.core.page.widget.b bVar;
        if (this.anh && (bVar = this.ana) != null) {
            bVar.setOpaque(false);
        }
        this.ana.setSurfaceTextureListener(new TextureView.SurfaceTextureListener() { // from class: com.kwad.components.core.video.DetailVideoView.1
            @Override // android.view.TextureView.SurfaceTextureListener
            public final void onSurfaceTextureSizeChanged(SurfaceTexture surfaceTexture, int i, int i2) {
            }

            @Override // android.view.TextureView.SurfaceTextureListener
            public final void onSurfaceTextureUpdated(SurfaceTexture surfaceTexture) {
            }

            @Override // android.view.TextureView.SurfaceTextureListener
            public final void onSurfaceTextureAvailable(SurfaceTexture surfaceTexture, int i, int i2) {
                if (DetailVideoView.this.anc == surfaceTexture) {
                    return;
                }
                DetailVideoView.this.anc = surfaceTexture;
                DetailVideoView.this.xH();
                DetailVideoView.this.ane = new Surface(surfaceTexture);
                if (DetailVideoView.this.anb != null) {
                    DetailVideoView.this.anb.setSurface(DetailVideoView.this.ane);
                }
                try {
                    if (DetailVideoView.this.anb == null || DetailVideoView.this.anb.isPlaying()) {
                        return;
                    }
                    DetailVideoView.this.anb.seekTo(DetailVideoView.this.anl);
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                }
            }

            @Override // android.view.TextureView.SurfaceTextureListener
            public final boolean onSurfaceTextureDestroyed(SurfaceTexture surfaceTexture) {
                try {
                    if (DetailVideoView.this.anb == null) {
                        return false;
                    }
                    DetailVideoView detailVideoView = DetailVideoView.this;
                    detailVideoView.anl = detailVideoView.anb.getCurrentPosition();
                    return false;
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTrace(th);
                    return false;
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void xH() {
        Surface surface = this.ane;
        if (surface != null) {
            try {
                surface.release();
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTrace(th);
            }
            this.ane = null;
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.ViewGroup, android.view.View
    public void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        xH();
        SurfaceTexture surfaceTexture = this.anc;
        if (surfaceTexture != null) {
            surfaceTexture.release();
            this.anc = null;
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.View
    public void onSizeChanged(int i, int i2, int i3, int i4) {
        int i5;
        super.onSizeChanged(i, i2, i3, i4);
        int i6 = this.anj;
        if (i6 <= 0 || (i5 = this.ank) <= 0) {
            return;
        }
        adaptVideoSize(i6, i5);
    }

    public void setMediaPlayer(b bVar) {
        this.anb = bVar;
        Surface surface = this.ane;
        if (surface == null || bVar == null) {
            return;
        }
        bVar.setSurface(surface);
    }

    public final void adaptVideoSize(int i, int i2) {
        VideoAdapters.a cVar;
        if (this.ana == null) {
            com.kwad.sdk.core.d.c.w("DetailVideoView", "adaptVideoSize mTextureView is null");
            return;
        }
        this.ank = i2;
        this.anj = i;
        if (this.anm.xI()) {
            int iXJ = this.anm.xJ();
            if (iXJ == 1) {
                cVar = new VideoAdapters.c();
            } else {
                cVar = iXJ != 2 ? null : new VideoAdapters.b();
            }
            if (cVar != null) {
                com.kwad.components.core.page.widget.b bVar = this.ana;
                cVar.a(bVar, (View) bVar.getParent(), i, i2);
                return;
            }
            return;
        }
        if (this.anm.xO()) {
            com.kwad.sdk.c.a.a.K(this.ana);
            return;
        }
        if (this.anm.xK()) {
            com.kwad.sdk.c.a.a.e(this.ana, i, i2);
            return;
        }
        if (this.anm.xM()) {
            com.kwad.sdk.c.a.a.f(this.ana, i, i2);
            return;
        }
        if (this.anm.xL()) {
            com.kwad.sdk.c.a.a.d(this.ana, i, i2);
            return;
        }
        if (this.anm.xN()) {
            a(this.ana, i, i2);
            return;
        }
        View view = (View) this.ana.getParent();
        if (view == null) {
            return;
        }
        int width = view.getWidth();
        int height = view.getHeight();
        if (width == 0 || height == 0) {
            return;
        }
        PhotoInfo.VideoInfo videoInfo = this.ang;
        if (videoInfo != null && com.kwad.sdk.core.response.helper.h.a(this.mMatrix, width, height, videoInfo)) {
            ViewGroup.LayoutParams layoutParams = this.ana.getLayoutParams();
            layoutParams.width = -1;
            layoutParams.height = -1;
            this.ana.setTransform(this.mMatrix);
            this.ana.setLayoutParams(layoutParams);
        } else {
            ViewGroup.LayoutParams layoutParams2 = this.ana.getLayoutParams();
            layoutParams2.width = width;
            layoutParams2.height = (int) ((i2 / (i * 1.0f)) * width);
            this.mMatrix.reset();
            this.ana.setTransform(this.mMatrix);
            this.ana.setLayoutParams(layoutParams2);
        }
        this.ani.set(this.ana.getLeft(), this.ana.getTop(), this.ana.getRight(), this.ana.getBottom());
    }

    private void a(View view, long j, long j2) {
        View view2;
        if (view == null || j == 0 || j2 == 0 || (view2 = (View) view.getParent()) == null) {
            return;
        }
        int width = view2.getWidth();
        int height = view2.getHeight();
        if (width == 0 || height == 0) {
            return;
        }
        view.getLayoutParams();
        float f = j / j2;
        float f2 = height * f;
        float f3 = width;
        if (f2 > f3) {
            height = (int) (f3 / f);
        } else {
            width = (int) f2;
        }
        if (width == 0 || height == 0) {
            height = -1;
            width = -1;
        }
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = width;
        layoutParams.height = height;
        this.ana.setLayoutParams(layoutParams);
    }

    @Deprecated
    public void setAd(boolean z) {
        this.anm.setAd(z);
    }

    public void setHorizontalVideo(boolean z) {
        this.anm.setHorizontalVideo(z);
    }

    @Deprecated
    public final void fixWidth(boolean z) {
        this.anm.bh(z);
    }

    @Deprecated
    public void setFillXY(boolean z) {
        this.anm.setFillXY(z);
    }

    @Deprecated
    public void setForce(boolean z) {
        this.anm.setForce(z);
    }

    public final void g(boolean z, int i) {
        this.anm.setAd(true);
        this.anm.bR(i);
    }

    public void setVideoInfo(PhotoInfo.VideoInfo videoInfo) {
        this.ang = videoInfo;
    }

    public void setClickListener(a aVar) {
        this.anf = aVar;
        setOnClickListener(this);
    }

    public final void updateTextureViewGravity(int i) {
        com.kwad.components.core.page.widget.b bVar = this.ana;
        if (bVar == null) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = bVar.getLayoutParams();
        if (layoutParams instanceof FrameLayout.LayoutParams) {
            ((FrameLayout.LayoutParams) layoutParams).gravity = i;
            this.ana.requestLayout();
        }
    }

    public int getTextureViewGravity() {
        com.kwad.components.core.page.widget.b bVar = this.ana;
        if (bVar == null) {
            return 17;
        }
        ViewGroup.LayoutParams layoutParams = bVar.getLayoutParams();
        if (layoutParams instanceof FrameLayout.LayoutParams) {
            return ((FrameLayout.LayoutParams) layoutParams).gravity;
        }
        return 17;
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        if (view == this.ana) {
            a aVar = this.anf;
            if (aVar != null) {
                aVar.onClickVideoView();
                return;
            }
            return;
        }
        a aVar2 = this.anf;
        if (aVar2 != null) {
            aVar2.onClickRootView();
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public void setRadius(float f) {
        com.kwad.components.core.widget.h.f(this, f);
    }

    public final ValueAnimator a(AdTemplate adTemplate, int i, final ValueAnimator.AnimatorUpdateListener animatorUpdateListener) {
        float height = getHeight();
        final float width = height / getWidth();
        final boolean Z = com.kwad.sdk.core.response.helper.a.Z(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        final ViewGroup.LayoutParams layoutParams = getLayoutParams();
        ValueAnimator valueAnimatorOfInt = ValueAnimator.ofInt((int) height, i);
        valueAnimatorOfInt.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.core.video.DetailVideoView.2
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
                if (Z) {
                    int i2 = (int) (iIntValue / width);
                    ViewGroup.LayoutParams layoutParams2 = layoutParams;
                    if (layoutParams2 != null) {
                        layoutParams2.height = iIntValue;
                        layoutParams.width = i2;
                        DetailVideoView.this.setLayoutParams(layoutParams);
                    }
                    DetailVideoView.this.adaptVideoSize(i2, iIntValue);
                } else {
                    ViewGroup.LayoutParams layoutParams3 = layoutParams;
                    if (layoutParams3 != null) {
                        layoutParams3.height = iIntValue;
                        layoutParams.width = -1;
                        DetailVideoView.this.setLayoutParams(layoutParams);
                    }
                }
                ValueAnimator.AnimatorUpdateListener animatorUpdateListener2 = animatorUpdateListener;
                if (animatorUpdateListener2 != null) {
                    animatorUpdateListener2.onAnimationUpdate(valueAnimator);
                }
            }
        });
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.0f, 0.0f, 0.58f, 1.0f);
        valueAnimatorOfInt.setDuration(500L);
        valueAnimatorOfInt.setInterpolator(interpolatorCreate);
        return valueAnimatorOfInt;
    }

    public final void bQ(int i) {
        if (com.kwad.components.core.a.oV.booleanValue()) {
            if (this.and == null) {
                if (getContext() == null) {
                    return;
                } else {
                    this.and = new TextView(getContext());
                }
            }
            removeView(this.and);
            this.and.setText(String.valueOf(i));
            this.and.setTextColor(SupportMenu.CATEGORY_MASK);
            FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
            layoutParams.gravity = 53;
            addView(this.and, getChildCount(), layoutParams);
        }
    }
}
