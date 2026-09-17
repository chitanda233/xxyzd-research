package com.kwad.components.ad.splashscreen.widget;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.ad.splashscreen.local.SplashSkipViewModel;
import com.kwad.sdk.R;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class SkipView extends LinearLayout implements com.kwad.components.ad.splashscreen.widget.b {
    private a KX;
    private Runnable Lj;
    private final b MN;
    private View MO;
    private TextView MP;
    private TextView MQ;
    private int MR;
    private boolean rh;
    private boolean wN;

    public interface a {
        void ao(int i);

        void my();

        void mz();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void an(int i) {
        a aVar = this.KX;
        if (aVar != null) {
            aVar.ao(i);
        }
    }

    public SkipView(Context context) {
        this(context, null);
    }

    public SkipView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public SkipView(Context context, AttributeSet attributeSet, int i) {
        super(m.wrapContextIfNeed(context), attributeSet, i);
        this.MN = new b((byte) 0);
        this.MR = -1;
        this.rh = false;
        this.wN = true;
        this.Lj = new Runnable() { // from class: com.kwad.components.ad.splashscreen.widget.SkipView.1
            @Override // java.lang.Runnable
            public final void run() {
                if (SkipView.this.rh) {
                    SkipView.this.postDelayed(this, 300L);
                    return;
                }
                SkipView skipView = SkipView.this;
                skipView.a(skipView.MN);
                SkipView skipView2 = SkipView.this;
                skipView2.an(skipView2.MN.MV - SkipView.this.MN.Le);
                if (SkipView.this.MN.of()) {
                    if (SkipView.this.KX != null) {
                        SkipView.this.KX.mz();
                    }
                } else {
                    SkipView.this.postDelayed(this, 1000L);
                    b.d(SkipView.this.MN);
                }
            }
        };
        init();
    }

    private void init() {
        setOrientation(0);
        m.inflate(getContext(), R.layout.ksad_skip_view, this);
        this.MP = (TextView) findViewById(R.id.ksad_skip_view_skip);
        this.MQ = (TextView) findViewById(R.id.ksad_skip_view_timer);
        this.MO = findViewById(R.id.ksad_skip_view_divider);
        setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.splashscreen.widget.SkipView.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (SkipView.this.KX != null) {
                    SkipView.this.KX.my();
                }
            }
        });
        setSkipBtnVisible(true);
        setTimerBtnVisible(true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(b bVar) {
        if (bVar == null) {
            return;
        }
        if (this.MP != null) {
            if (bVar.MT != null) {
                this.MP.setText(bVar.MT);
            }
            this.MP.setVisibility(this.MN.MW ? 0 : 8);
        }
        String strOe = bVar.oe();
        TextView textView = this.MQ;
        if (textView != null) {
            if (strOe != null) {
                textView.setText(strOe);
            }
            this.MQ.setVisibility(this.MN.MX ? 0 : 8);
        }
        if (this.MO != null) {
            boolean zOg = this.MN.og();
            this.MO.setVisibility(zOg ? 0 : 8);
            ViewGroup.LayoutParams layoutParams = getLayoutParams();
            if (layoutParams != null) {
                if (!zOg) {
                    layoutParams.width = -2;
                    invalidate();
                    return;
                }
                int i = this.MR;
                if (i > 0) {
                    layoutParams.width = i;
                    invalidate();
                }
            }
        }
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void B(AdInfo adInfo) {
        if (com.kwad.sdk.core.response.helper.a.bi(adInfo)) {
            return;
        }
        fZ();
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void C(AdInfo adInfo) {
        if (this.wN) {
            od();
        }
        if (com.kwad.sdk.core.response.helper.a.bi(adInfo)) {
            return;
        }
        ga();
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final int aq(int i) {
        ViewGroup.LayoutParams layoutParams = getLayoutParams();
        layoutParams.height = com.kwad.sdk.c.a.a.a(getContext(), 35.0f);
        int width = getWidth();
        setLayoutParams(layoutParams);
        return width;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public void setOnViewListener(a aVar) {
        this.KX = aVar;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void a(SplashSkipViewModel splashSkipViewModel, AdInfo adInfo) {
        this.wN = com.kwad.sdk.core.response.helper.a.cK(adInfo);
        setTimerPrefixText(e.a(com.kwad.components.ad.splashscreen.b.a.Hc));
        setTimerSecond(splashSkipViewModel.skipSecond);
        if (!com.kwad.sdk.core.response.helper.a.bi(adInfo)) {
            aw();
        }
        setSkipText(com.kwad.sdk.core.response.helper.a.cz(adInfo));
        setVisibility(8);
        D(adInfo);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.b
    public final void cs() {
        if (getHandler() != null) {
            getHandler().removeCallbacksAndMessages(null);
        }
    }

    private void D(AdInfo adInfo) {
        setTimerBtnVisible(com.kwad.sdk.core.response.helper.a.cL(adInfo));
    }

    public void setSkipBtnVisible(boolean z) {
        this.MN.MW = z;
        a(this.MN);
    }

    public void setTimerBtnVisible(boolean z) {
        this.MN.MX = z;
        a(this.MN);
    }

    public void setTimerPrefixText(String str) {
        this.MN.MU = str;
        a(this.MN);
    }

    public void setTimerSecond(int i) {
        this.MN.at(i);
        a(this.MN);
    }

    public void setSkipText(String str) {
        this.MN.MT = str;
        a(this.MN);
    }

    public final void ae(String str) {
        if (str == null) {
            return;
        }
        this.MN.ae(str);
        a(this.MN);
    }

    private void aw() {
        a(this.MN);
        post(this.Lj);
    }

    private void od() {
        if (getVisibility() == 0) {
            return;
        }
        setVisibility(0);
        setAlpha(0.0f);
        animate().alpha(1.0f).setDuration(500L).start();
    }

    private void fZ() {
        this.rh = true;
    }

    private void ga() {
        this.rh = false;
    }

    @Override // android.view.View
    public void setLayoutParams(ViewGroup.LayoutParams layoutParams) {
        super.setLayoutParams(layoutParams);
        this.MR = layoutParams.width;
    }

    static class b {
        private int Le;
        private String MT;
        private String MU;
        private int MV;
        private boolean MW;
        private boolean MX;

        private b() {
            this.MT = "跳过";
            this.MU = "";
            this.MV = 5;
            this.Le = 5;
            this.MW = true;
            this.MX = true;
        }

        /* synthetic */ b(byte b) {
            this();
        }

        static /* synthetic */ int d(b bVar) {
            int i = bVar.Le;
            bVar.Le = i - 1;
            return i;
        }

        public final String oe() {
            int i = this.Le;
            if (i < 0) {
                return this.MU;
            }
            if (i == 0) {
                return this.MU + 1;
            }
            return this.MU + this.Le;
        }

        public final boolean of() {
            return this.Le <= 0;
        }

        public final void at(int i) {
            this.MV = i;
            this.Le = i;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public boolean og() {
            return this.MW && this.MX;
        }

        public final void ae(String str) {
            this.Le = -1;
            this.MU = str;
        }
    }
}
