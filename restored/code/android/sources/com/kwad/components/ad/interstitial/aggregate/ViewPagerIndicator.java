package com.kwad.components.ad.interstitial.aggregate;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.RectF;
import android.util.AttributeSet;
import android.view.View;
import androidx.viewpager.widget.PagerAdapter;
import androidx.viewpager.widget.ViewPager;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public class ViewPagerIndicator extends View {
    private int lM;
    private int lS;
    private int lT;
    private int lU;
    private float lV;
    private float lW;
    private Paint lX;
    private float lY;
    private float lZ;
    private final Context mContext;
    private float ma;
    private int mb;
    private Paint mc;
    private float md;
    private a me;
    private ValueAnimator mf;

    public interface a {
        void I(int i);
    }

    public ViewPagerIndicator(Context context) {
        this(context, null);
    }

    public ViewPagerIndicator(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public ViewPagerIndicator(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mContext = context;
        setWillNotDraw(false);
        a(context, attributeSet, i);
        dJ();
    }

    private void a(Context context, AttributeSet attributeSet, int i) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_ViewPagerIndicator, i, 0);
        this.lW = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_ViewPagerIndicator_ksad_dot_distance, com.kwad.sdk.c.a.a.a(this.mContext, 5.0f));
        this.lY = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_ViewPagerIndicator_ksad_dot_height, com.kwad.sdk.c.a.a.a(this.mContext, 6.0f));
        this.lZ = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_ViewPagerIndicator_ksad_dot_selected_width, com.kwad.sdk.c.a.a.a(this.mContext, 50.0f));
        this.ma = typedArrayObtainStyledAttributes.getDimension(R.styleable.ksad_ViewPagerIndicator_ksad_dot_unselected_width, com.kwad.sdk.c.a.a.a(this.mContext, 6.0f));
        this.lT = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_ViewPagerIndicator_ksad_default_color, getResources().getColor(R.color.ksad_88_white));
        this.lS = typedArrayObtainStyledAttributes.getColor(R.styleable.ksad_ViewPagerIndicator_ksad_height_color, getResources().getColor(R.color.ksad_white));
        typedArrayObtainStyledAttributes.recycle();
    }

    private void dJ() {
        Paint paint = new Paint(1);
        this.lX = paint;
        paint.setStyle(Paint.Style.FILL_AND_STROKE);
        this.lX.setStrokeWidth(1.0f);
        this.lX.setColor(this.lT);
        Paint paint2 = new Paint(1);
        this.mc = paint2;
        paint2.setStyle(Paint.Style.FILL_AND_STROKE);
        this.mc.setStrokeWidth(1.0f);
        this.mc.setColor(this.lS);
    }

    @Override // android.view.View
    protected void onMeasure(int i, int i2) {
        super.onMeasure(i, i2);
        int size = View.MeasureSpec.getSize(i);
        int size2 = View.MeasureSpec.getSize(i2);
        int mode = View.MeasureSpec.getMode(i);
        int mode2 = View.MeasureSpec.getMode(i2);
        if (mode2 != 1073741824) {
            size2 = mode2 == Integer.MIN_VALUE ? (int) this.lY : 0;
        }
        if (mode != 1073741824) {
            if (mode == Integer.MIN_VALUE) {
                int i3 = this.lU;
                if (i3 > 1) {
                    size = (int) (this.lZ + ((i3 - 1) * (this.lW + this.ma)));
                } else {
                    size = (int) this.lZ;
                }
            } else {
                size = 0;
            }
        }
        setMeasuredDimension(size, size2);
    }

    @Override // android.view.View
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        a(canvas);
        b(canvas);
    }

    private void a(Canvas canvas) {
        RectF rectF = new RectF();
        for (int i = 0; i < this.lU; i++) {
            int i2 = this.lM;
            if (i < i2 && i != i2 - 1) {
                rectF.left = i * (this.lW + this.ma);
                rectF.right = rectF.left + this.ma;
                this.lX.setColor(this.lT);
            } else if (i == i2 - 1) {
                rectF.left = i * (this.lW + this.ma);
                float f = rectF.left;
                float f2 = this.ma;
                rectF.right = f + f2 + ((this.lZ - f2) * (1.0f - this.lV));
                this.lX.setColor(this.lT);
            } else if (i == i2) {
                float f3 = i2 != 0 ? this.lV : 1.0f;
                float f4 = this.lW;
                float f5 = this.ma;
                rectF.left = ((i - 1) * (f4 + f5)) + f5 + ((this.lZ - f5) * (1.0f - f3)) + f4;
                float f6 = rectF.left;
                float f7 = this.lZ;
                float f8 = this.ma;
                rectF.right = f6 + (f3 * (f7 - f8)) + f8;
                this.lX.setColor(this.lT);
            } else {
                float f9 = this.lW;
                rectF.left = ((i - 1) * (this.ma + f9)) + f9 + this.lZ;
                rectF.right = rectF.left + this.ma;
                this.lX.setColor(this.lT);
            }
            rectF.top = 0.0f;
            rectF.bottom = rectF.top + this.lY;
            float f10 = this.lY;
            canvas.drawRoundRect(rectF, f10 / 2.0f, f10 / 2.0f, this.lX);
        }
    }

    private void b(Canvas canvas) {
        if (this.md > 0.0f) {
            int i = this.lM;
            float f = this.lW;
            float f2 = this.ma;
            RectF rectF = new RectF(i * (f + f2), 0.0f, (i * (f + f2)) + this.md, this.lY);
            float f3 = this.lY;
            canvas.drawRoundRect(rectF, f3 / 2.0f, f3 / 2.0f, this.mc);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void K(final int i) {
        if (this.mb <= 0) {
            setVisibility(8);
            return;
        }
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(this.ma, this.lZ);
        this.mf = valueAnimatorOfFloat;
        valueAnimatorOfFloat.setDuration(((long) this.mb) * 1000);
        this.mf.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.interstitial.aggregate.ViewPagerIndicator.1
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                ViewPagerIndicator.this.md = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                ViewPagerIndicator.this.invalidate();
            }
        });
        this.mf.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.interstitial.aggregate.ViewPagerIndicator.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                if (ViewPagerIndicator.this.me != null) {
                    ViewPagerIndicator.this.me.I(i);
                }
            }
        });
        this.mf.start();
    }

    public final void dK() {
        ValueAnimator valueAnimator = this.mf;
        if (valueAnimator != null) {
            valueAnimator.pause();
        }
    }

    public final void dL() {
        ValueAnimator valueAnimator = this.mf;
        if (valueAnimator != null) {
            valueAnimator.resume();
        }
    }

    public void setViewPager(ViewPager viewPager) {
        PagerAdapter adapter = viewPager.getAdapter();
        if (adapter == null) {
            return;
        }
        int count = adapter.getCount();
        this.lU = count;
        if (count <= 1) {
            return;
        }
        viewPager.addOnPageChangeListener(new ViewPager.OnPageChangeListener() { // from class: com.kwad.components.ad.interstitial.aggregate.ViewPagerIndicator.3
            @Override // androidx.viewpager.widget.ViewPager.OnPageChangeListener
            public final void onPageScrollStateChanged(int i) {
            }

            @Override // androidx.viewpager.widget.ViewPager.OnPageChangeListener
            public final void onPageScrolled(int i, float f, int i2) {
                ViewPagerIndicator.this.md = 0.0f;
                ViewPagerIndicator.this.lM = i;
                ViewPagerIndicator.this.lV = f;
                ViewPagerIndicator.this.invalidate();
            }

            @Override // androidx.viewpager.widget.ViewPager.OnPageChangeListener
            public final void onPageSelected(int i) {
                ViewPagerIndicator.this.lM = i;
                ViewPagerIndicator.this.lV = 1.0f;
                ViewPagerIndicator.this.invalidate();
                if (i < ViewPagerIndicator.this.lU - 1) {
                    ViewPagerIndicator.this.K(i);
                }
            }
        });
        K(this.lM);
    }

    public void setAdShowTime(int i) {
        this.mb = i;
    }

    public void setPlayProgressListener(a aVar) {
        this.me = aVar;
    }
}
