package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.LinearGradient;
import android.graphics.Matrix;
import android.graphics.Paint;
import android.graphics.PorterDuff;
import android.graphics.PorterDuffXfermode;
import android.graphics.Shader;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.ViewConfiguration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

/* JADX INFO: loaded from: classes3.dex */
public class LiveCommentsView extends e {
    private float MI;
    private Paint ZN;
    private Matrix ZO;
    private Shader ZP;
    private int ZQ;
    private int ZR;
    private boolean ZS;
    private boolean ZU;
    private int mTouchSlop;

    private static boolean tp() {
        return true;
    }

    static /* synthetic */ boolean a(LiveCommentsView liveCommentsView, boolean z) {
        liveCommentsView.ZS = false;
        return false;
    }

    public LiveCommentsView(Context context) {
        this(context, null);
    }

    public LiveCommentsView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public LiveCommentsView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.MI = 0.0f;
        this.ZS = false;
        this.ZU = false;
        init();
    }

    private void init() {
        this.ZN = new Paint();
        LinearGradient linearGradient = new LinearGradient(0.0f, 0.0f, 0.0f, 1.0f, -16777216, 0, Shader.TileMode.CLAMP);
        this.ZP = linearGradient;
        this.ZN.setShader(linearGradient);
        this.ZN.setXfermode(new PorterDuffXfermode(PorterDuff.Mode.DST_OUT));
        this.ZO = new Matrix();
        this.ZR = com.kwad.sdk.c.a.a.a(getContext(), 30.0f);
        to();
        this.ZU = true;
        this.mTouchSlop = ViewConfiguration.get(getContext()).getScaledTouchSlop();
        tn();
    }

    private void tn() {
        addOnScrollListener(new RecyclerView.OnScrollListener() { // from class: com.kwad.components.core.innerEc.live.widget.LiveCommentsView.1
            public final void onScrolled(RecyclerView recyclerView, int i, int i2) {
                LinearLayoutManager layoutManager = recyclerView.getLayoutManager();
                if ((layoutManager instanceof LinearLayoutManager) && LiveCommentsView.this.getAdapter() != null && layoutManager.findLastCompletelyVisibleItemPosition() == LiveCommentsView.this.getAdapter().getItemCount() - 1) {
                    LiveCommentsView.a(LiveCommentsView.this, false);
                }
            }
        });
    }

    private void to() {
        if (tp()) {
            setLayerType(2, null);
        }
    }

    public void setCustomFadingEdgeTop(int i) {
        if (this.ZQ == i || this.ZR <= 0) {
            return;
        }
        this.ZQ = i;
        postInvalidate();
    }

    public int getCustomFadingEdgeTop() {
        return this.ZQ;
    }

    public void setCustomFadingEdgeLength(int i) {
        this.ZR = i;
    }

    private void c(Canvas canvas) {
        int i = this.ZQ;
        int width = getWidth();
        int i2 = this.ZR;
        this.ZO.setScale(1.0f, i2);
        this.ZO.postTranslate(0.0f, i);
        this.ZP.setLocalMatrix(this.ZO);
        this.ZN.setShader(this.ZP);
        canvas.drawRect(0.0f, 0.0f, width, i + i2, this.ZN);
    }

    public boolean canScrollVertically(int i) {
        if (!this.ZU) {
            return aZ(i);
        }
        if (this.ZS) {
            return aZ(i);
        }
        if (i < 0) {
            return aZ(i);
        }
        return false;
    }

    private boolean aZ(int i) {
        return super.canScrollVertically(i);
    }

    public void draw(Canvas canvas) {
        super.draw(canvas);
        if (this.ZR <= 0 || !tp()) {
            return;
        }
        c(canvas);
    }

    public boolean onTouchEvent(MotionEvent motionEvent) {
        if (!this.ZU) {
            return super.onTouchEvent(motionEvent);
        }
        int action = motionEvent.getAction();
        if (action == 0) {
            this.MI = motionEvent.getY();
        } else if (action == 2 && motionEvent.getY() - this.MI >= this.mTouchSlop) {
            this.ZS = true;
        }
        boolean zOnTouchEvent = super.onTouchEvent(motionEvent);
        if (!this.ZS) {
            getParent().requestDisallowInterceptTouchEvent(false);
        }
        return zOnTouchEvent;
    }
}
