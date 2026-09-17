package com.kwad.components.core.innerEc.live.widget;

import android.text.TextPaint;
import android.text.style.CharacterStyle;

/* JADX INFO: loaded from: classes3.dex */
public final class o extends CharacterStyle {
    private int Fp;
    private boolean aaL;
    private float mRadius = 3.0f;
    private float aaJ = 0.0f;
    private float aaK = 3.0f;

    public o(float f, float f2, float f3, int i) {
        this.Fp = i;
    }

    public final void aO(boolean z) {
        this.aaL = true;
    }

    @Override // android.text.style.CharacterStyle
    public final void updateDrawState(TextPaint textPaint) {
        if (this.aaL) {
            textPaint.setShadowLayer(this.mRadius, this.aaJ, this.aaK, this.Fp);
        }
    }
}
