package com.kwad.components.ad.splashscreen.widget;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.GradientDrawable;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.am;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class CloseCountDownView extends LinearLayout {
    private a JK;
    private String Ld;
    private int Le;
    private TextView Lf;
    private TextView Lg;
    private ImageView Lh;
    private com.kwad.components.ad.splashscreen.widget.a Li;
    private Runnable Lj;
    private boolean rh;

    public interface a {
        void em();

        void mz();
    }

    static /* synthetic */ int d(CloseCountDownView closeCountDownView) {
        int i = closeCountDownView.Le;
        closeCountDownView.Le = i - 1;
        return i;
    }

    public CloseCountDownView(Context context) {
        super(context);
        this.Ld = "%ss";
        this.Le = 5;
        this.rh = false;
        this.Lj = new Runnable() { // from class: com.kwad.components.ad.splashscreen.widget.CloseCountDownView.1
            @Override // java.lang.Runnable
            public final void run() {
                if (!CloseCountDownView.this.rh) {
                    if (CloseCountDownView.this.Le <= 0) {
                        if (CloseCountDownView.this.JK != null) {
                            CloseCountDownView.this.JK.mz();
                            return;
                        }
                        return;
                    } else {
                        CloseCountDownView.this.postDelayed(this, 1000L);
                        CloseCountDownView closeCountDownView = CloseCountDownView.this;
                        closeCountDownView.ar(closeCountDownView.Le);
                        CloseCountDownView.d(CloseCountDownView.this);
                        return;
                    }
                }
                CloseCountDownView.this.postDelayed(this, 300L);
            }
        };
        ah(context);
    }

    public CloseCountDownView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.Ld = "%ss";
        this.Le = 5;
        this.rh = false;
        this.Lj = new Runnable() { // from class: com.kwad.components.ad.splashscreen.widget.CloseCountDownView.1
            @Override // java.lang.Runnable
            public final void run() {
                if (!CloseCountDownView.this.rh) {
                    if (CloseCountDownView.this.Le <= 0) {
                        if (CloseCountDownView.this.JK != null) {
                            CloseCountDownView.this.JK.mz();
                            return;
                        }
                        return;
                    } else {
                        CloseCountDownView.this.postDelayed(this, 1000L);
                        CloseCountDownView closeCountDownView = CloseCountDownView.this;
                        closeCountDownView.ar(closeCountDownView.Le);
                        CloseCountDownView.d(CloseCountDownView.this);
                        return;
                    }
                }
                CloseCountDownView.this.postDelayed(this, 300L);
            }
        };
        ah(context);
    }

    public CloseCountDownView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.Ld = "%ss";
        this.Le = 5;
        this.rh = false;
        this.Lj = new Runnable() { // from class: com.kwad.components.ad.splashscreen.widget.CloseCountDownView.1
            @Override // java.lang.Runnable
            public final void run() {
                if (!CloseCountDownView.this.rh) {
                    if (CloseCountDownView.this.Le <= 0) {
                        if (CloseCountDownView.this.JK != null) {
                            CloseCountDownView.this.JK.mz();
                            return;
                        }
                        return;
                    } else {
                        CloseCountDownView.this.postDelayed(this, 1000L);
                        CloseCountDownView closeCountDownView = CloseCountDownView.this;
                        closeCountDownView.ar(closeCountDownView.Le);
                        CloseCountDownView.d(CloseCountDownView.this);
                        return;
                    }
                }
                CloseCountDownView.this.postDelayed(this, 300L);
            }
        };
        ah(context);
    }

    public CloseCountDownView(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        this.Ld = "%ss";
        this.Le = 5;
        this.rh = false;
        this.Lj = new Runnable() { // from class: com.kwad.components.ad.splashscreen.widget.CloseCountDownView.1
            @Override // java.lang.Runnable
            public final void run() {
                if (!CloseCountDownView.this.rh) {
                    if (CloseCountDownView.this.Le <= 0) {
                        if (CloseCountDownView.this.JK != null) {
                            CloseCountDownView.this.JK.mz();
                            return;
                        }
                        return;
                    } else {
                        CloseCountDownView.this.postDelayed(this, 1000L);
                        CloseCountDownView closeCountDownView = CloseCountDownView.this;
                        closeCountDownView.ar(closeCountDownView.Le);
                        CloseCountDownView.d(CloseCountDownView.this);
                        return;
                    }
                }
                CloseCountDownView.this.postDelayed(this, 300L);
            }
        };
        ah(context);
    }

    private void ah(Context context) {
        setOrientation(0);
        m.inflate(context, R.layout.ksad_endcard_close_view, this);
        this.Lf = (TextView) findViewById(R.id.ksad_ad_endcard_second);
        this.Lg = (TextView) findViewById(R.id.ksad_ad_endcard_line);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_splash_endcard_close_img);
        this.Lh = imageView;
        imageView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.splashscreen.widget.CloseCountDownView.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (CloseCountDownView.this.JK != null) {
                    CloseCountDownView.this.JK.em();
                }
            }
        });
    }

    public final void bw() {
        fZ();
    }

    public final void bv() {
        ga();
    }

    public void setOnViewClickListener(a aVar) {
        this.JK = aVar;
    }

    public final void a(AdInfo adInfo, float f) {
        com.kwad.components.ad.splashscreen.widget.a aVarAi;
        boolean zDv = com.kwad.sdk.core.response.helper.a.dv(adInfo);
        if (zDv) {
            aVarAi = com.kwad.components.ad.splashscreen.widget.a.aj(getContext());
        } else {
            aVarAi = com.kwad.components.ad.splashscreen.widget.a.ai(getContext());
        }
        this.Li = aVarAi;
        aVarAi.d(f);
        boolean zCC = com.kwad.sdk.core.response.helper.a.cC(adInfo);
        this.Le = com.kwad.sdk.core.response.helper.a.cB(adInfo);
        if (zDv) {
            nQ();
        }
        if (zCC) {
            this.Lf.setVisibility(0);
            this.Lg.setVisibility(0);
            ar(this.Le);
            float fNS = this.Li.nS();
            setPadding(com.kwad.sdk.c.a.a.a(getContext(), fNS), 0, com.kwad.sdk.c.a.a.a(getContext(), fNS), 0);
        } else {
            float fNR = this.Li.nR();
            setPadding(com.kwad.sdk.c.a.a.a(getContext(), fNR), 0, com.kwad.sdk.c.a.a.a(getContext(), fNR), 0);
        }
        aw();
    }

    private void nQ() {
        am.a(this, this.Li.nu());
        am.a(this.Lg, this.Li.nT());
        am.a(this.Lh, this.Li.nW());
        this.Lf.setTextSize(0, this.Li.nU());
        this.Lg.setTextSize(0, this.Li.nU());
        Drawable background = getBackground();
        if (background instanceof GradientDrawable) {
            ((GradientDrawable) background).setCornerRadius(this.Li.nV());
        }
    }

    public final void cs() {
        if (getHandler() != null) {
            getHandler().removeCallbacksAndMessages(null);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ar(int i) {
        this.Lf.setText(String.format(this.Ld, Integer.valueOf(i)));
    }

    private void aw() {
        post(this.Lj);
    }

    private void fZ() {
        this.rh = true;
    }

    private void ga() {
        this.rh = false;
    }
}
