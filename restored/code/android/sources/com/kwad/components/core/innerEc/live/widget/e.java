package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import android.content.res.TypedArray;
import android.os.Build;
import android.util.AttributeSet;
import androidx.recyclerview.widget.RecyclerView;
import com.kwad.sdk.R;
import java.util.Locale;

/* JADX INFO: loaded from: classes3.dex */
public class e extends RecyclerView {
    private boolean YP;
    private boolean YQ;
    private boolean YR;
    private boolean YS;

    public e(Context context) {
        this(context, null);
    }

    public e(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public e(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_CustomFadeEdgeRecyclerView);
        this.YP = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_CustomFadeEdgeRecyclerView_ksad_cerv_enableTopFadingEdge, false);
        this.YQ = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_CustomFadeEdgeRecyclerView_ksad_cerv_enableBottomFadingEdge, false);
        this.YR = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_CustomFadeEdgeRecyclerView_ksad_cerv_enableLeftFadingEdge, false);
        this.YS = typedArrayObtainStyledAttributes.getBoolean(R.styleable.ksad_CustomFadeEdgeRecyclerView_ksad_cerv_enableRightFadingEdge, false);
        typedArrayObtainStyledAttributes.recycle();
        td();
    }

    private void td() {
        if (Build.MANUFACTURER.toLowerCase(Locale.US).contains("meitu")) {
            return;
        }
        setVerticalFadingEdgeEnabled(this.YP || this.YQ);
        setHorizontalFadingEdgeEnabled(this.YR || this.YS);
    }

    public e(Context context, Boolean bool, Boolean bool2, Boolean bool3, Boolean bool4) {
        super(context, (AttributeSet) null, 0);
        this.YP = bool == null ? false : bool.booleanValue();
        this.YQ = bool2 == null ? false : bool2.booleanValue();
        this.YR = bool3 == null ? false : bool3.booleanValue();
        this.YS = bool4 != null ? bool4.booleanValue() : false;
        td();
    }

    public void setEnableRightFadingEdge(boolean z) {
        this.YS = z;
    }

    public void setEnableTopFadingEdge(boolean z) {
        this.YP = z;
    }

    public void setEnableBottomFadingEdge(boolean z) {
        this.YQ = z;
    }

    public void setEnableLeftFadingEdge(boolean z) {
        this.YR = z;
    }

    protected float getTopFadingEdgeStrength() {
        if (this.YP) {
            return super.getTopFadingEdgeStrength();
        }
        return 0.0f;
    }

    protected float getBottomFadingEdgeStrength() {
        if (this.YQ) {
            return super.getBottomFadingEdgeStrength();
        }
        return 0.0f;
    }

    protected float getLeftFadingEdgeStrength() {
        if (this.YR) {
            return super.getLeftFadingEdgeStrength();
        }
        return 0.0f;
    }

    protected float getRightFadingEdgeStrength() {
        if (this.YS) {
            return super.getRightFadingEdgeStrength();
        }
        return 0.0f;
    }
}
