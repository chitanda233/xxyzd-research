package com.kwad.components.ad.splashscreen.widget;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.view.View;
import android.view.animation.LinearInterpolator;
import android.widget.FrameLayout;
import android.widget.TextView;
import com.kwad.components.ad.splashscreen.local.SplashSkipViewModel;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public class CircleSkipView extends KSFrameLayout implements b {
    private float KS;
    private float KT;
    private int KU;
    private ValueAnimator KV;
    private boolean KW;
    private SkipView.a KX;
    private long KY;
    private float KZ;
    private Paint mPaint;
    private RectF mRectF;
    private int padding;
    private int radius;
    private boolean wN;

    static /* synthetic */ boolean a(CircleSkipView circleSkipView, boolean z) {
        circleSkipView.KW = true;
        return true;
    }

    public CircleSkipView(Context context) {
        this(context, null, 0);
    }

    public CircleSkipView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public CircleSkipView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mPaint = new Paint();
        this.KS = 270.0f;
        this.KT = 360.0f;
        this.radius = 0;
        this.KU = 0;
        this.KW = false;
        this.KY = 0L;
        this.KZ = 0.0f;
        this.padding = 0;
        this.wN = true;
        O(context);
    }

    private void O(Context context) {
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
        layoutParams.gravity = 17;
        af(context);
        addView(ag(context), layoutParams);
        setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.splashscreen.widget.CircleSkipView.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (CircleSkipView.this.KX != null) {
                    CircleSkipView.this.KX.my();
                }
            }
        });
    }

    private void af(Context context) {
        this.KU = com.kwad.sdk.c.a.a.a(context, 2.0f);
        int iA = com.kwad.sdk.c.a.a.a(context, 32.0f);
        int i = this.KU;
        this.radius = iA - i;
        this.padding = i / 2;
        int i2 = this.padding;
        int i3 = this.radius;
        this.mRectF = new RectF(i2, i2, i3 + i2, i3 + i2);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.ViewGroup, android.view.View
    public void dispatchDraw(Canvas canvas) {
        float fMin = Math.min(getWidth(), getHeight()) / 2.0f;
        setBgCirclePaint(this.mPaint);
        canvas.drawCircle(getWidth() / 2.0f, getHeight() / 2.0f, fMin - this.KU, this.mPaint);
        setOuterCirclePaint(this.mPaint);
        canvas.drawArc(this.mRectF, 0.0f, 360.0f, false, this.mPaint);
        if (this.KW) {
            setAnimationPaint(this.mPaint);
            canvas.drawArc(this.mRectF, this.KS, -this.KT, false, this.mPaint);
        }
        super.dispatchDraw(canvas);
    }

    private void setOuterCirclePaint(Paint paint) {
        paint.reset();
        paint.setStyle(Paint.Style.STROKE);
        paint.setStrokeWidth(this.KU);
        paint.setColor(Color.parseColor("#33FFFFFF"));
        paint.setAntiAlias(true);
    }

    private void setBgCirclePaint(Paint paint) {
        paint.reset();
        paint.setStyle(Paint.Style.FILL);
        paint.setColor(Color.parseColor("#4D000000"));
        paint.setAntiAlias(true);
    }

    private void setAnimationPaint(Paint paint) {
        paint.reset();
        paint.setAntiAlias(true);
        paint.setStyle(Paint.Style.STROKE);
        paint.setStrokeWidth(this.KU);
        paint.setColor(-1);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void B(AdInfo adInfo) {
        by.postOnUiThread(new Runnable() { // from class: com.kwad.components.ad.splashscreen.widget.CircleSkipView.2
            @Override // java.lang.Runnable
            public final void run() {
                CircleSkipView.this.nP();
            }
        });
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void C(AdInfo adInfo) {
        nO();
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public void setOnViewListener(SkipView.a aVar) {
        this.KX = aVar;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void a(SplashSkipViewModel splashSkipViewModel, AdInfo adInfo) {
        this.wN = com.kwad.sdk.core.response.helper.a.cK(adInfo);
        boolean zCL = com.kwad.sdk.core.response.helper.a.cL(adInfo);
        if (this.wN) {
            setVisibility(0);
        }
        c(splashSkipViewModel.skipSecond * 1000, zCL);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void cs() {
        nP();
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final int aq(int i) {
        getLayoutParams().height = com.kwad.sdk.c.a.a.a(getContext(), 35.0f);
        return getWidth();
    }

    private static TextView ag(Context context) {
        TextView textView = new TextView(context);
        textView.setText(context.getString(R.string.ksad_skip_text));
        textView.setTextColor(-1);
        textView.setTextSize(12.0f);
        return textView;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void an(int i) {
        SkipView.a aVar = this.KX;
        if (aVar != null) {
            aVar.ao(i);
        }
    }

    private void c(final int i, final boolean z) {
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 1.0f);
        this.KV = valueAnimatorOfFloat;
        valueAnimatorOfFloat.setDuration(i);
        this.KV.setInterpolator(new LinearInterpolator());
        this.KV.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.splashscreen.widget.CircleSkipView.3
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                if (CircleSkipView.this.KZ != 1.0f || CircleSkipView.this.KX == null) {
                    return;
                }
                CircleSkipView.this.KX.mz();
            }
        });
        this.KV.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.splashscreen.widget.CircleSkipView.4
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                float fFloatValue = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                CircleSkipView.this.KZ = fFloatValue;
                CircleSkipView circleSkipView = CircleSkipView.this;
                circleSkipView.an((int) ((i / 1000) * circleSkipView.KZ));
                if (z) {
                    CircleSkipView.a(CircleSkipView.this, true);
                    float f = fFloatValue * 360.0f;
                    CircleSkipView.this.KS = 270.0f - f;
                    CircleSkipView.this.KT = 360.0f - f;
                    CircleSkipView.this.invalidate();
                }
            }
        });
    }

    private void nO() {
        this.KW = true;
        ValueAnimator valueAnimator = this.KV;
        if (valueAnimator != null) {
            valueAnimator.setCurrentPlayTime(this.KY);
            this.KV.start();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void nP() {
        this.KW = false;
        ValueAnimator valueAnimator = this.KV;
        if (valueAnimator != null) {
            this.KY = valueAnimator.getCurrentPlayTime();
            this.KV.cancel();
        }
    }
}
