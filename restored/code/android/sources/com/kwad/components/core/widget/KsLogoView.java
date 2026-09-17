package com.kwad.components.core.widget;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.assist.FailReason;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class KsLogoView extends LinearLayout {
    private boolean awt;
    TextView awu;
    ImageView awv;
    private a aww;
    private SimpleImageLoadingListener hM;

    public interface a {
        void bG();
    }

    public TextView getTextView() {
        return this.awu;
    }

    public ImageView getIcon() {
        return this.awv;
    }

    public KsLogoView(Context context) {
        this(context, (AttributeSet) null);
    }

    public KsLogoView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public KsLogoView(Context context, AttributeSet attributeSet, int i) {
        super(m.wrapContextIfNeed(context), attributeSet, i);
        this.hM = new SimpleImageLoadingListener() { // from class: com.kwad.components.core.widget.KsLogoView.1
            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final void onLoadingFailed(String str, View view, FailReason failReason) {
                KsLogoView.this.Ai();
                if (KsLogoView.this.aww != null) {
                    KsLogoView.this.aww.bG();
                }
            }

            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final void onLoadingComplete(String str, View view, DecodedResult decodedResult) {
                if (KsLogoView.this.aww != null) {
                    KsLogoView.this.aww.bG();
                }
            }
        };
        init();
    }

    public KsLogoView(Context context, boolean z) {
        super(m.wrapContextIfNeed(context));
        this.hM = new SimpleImageLoadingListener() { // from class: com.kwad.components.core.widget.KsLogoView.1
            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final void onLoadingFailed(String str, View view, FailReason failReason) {
                KsLogoView.this.Ai();
                if (KsLogoView.this.aww != null) {
                    KsLogoView.this.aww.bG();
                }
            }

            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final void onLoadingComplete(String str, View view, DecodedResult decodedResult) {
                if (KsLogoView.this.aww != null) {
                    KsLogoView.this.aww.bG();
                }
            }
        };
        if (z) {
            setBackground(getResources().getDrawable(R.drawable.ksad_splash_logo_bg));
        }
        init();
    }

    private void init() {
        m.inflate(getContext(), R.layout.ksad_logo_layout, this);
        this.awu = (TextView) findViewById(R.id.ksad_logo_text);
        this.awv = (ImageView) findViewById(R.id.ksad_logo_icon);
        boolean z = getBackground() == null;
        this.awt = z;
        if (z) {
            this.awv.setImageDrawable(getResources().getDrawable(R.drawable.ksad_logo_gray));
            this.awu.setTextColor(-6513508);
        } else {
            this.awv.setImageDrawable(getResources().getDrawable(R.drawable.ksad_logo_white));
            this.awu.setTextColor(-1711276033);
        }
    }

    public final void bh(AdTemplate adTemplate) {
        View viewFindViewById = findViewById(R.id.ksad_logo_container);
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        String str = this.awt ? adInfoEM.adBaseInfo.adGrayMarkIcon : adInfoEM.adBaseInfo.adMarkIcon;
        if (TextUtils.isEmpty(str) && TextUtils.isEmpty(adInfoEM.adBaseInfo.adSourceDescription)) {
            this.awu.setVisibility(0);
            this.awu.setText(com.kwad.sdk.core.response.helper.a.aJ(adInfoEM));
            this.awv.setVisibility(0);
            Ai();
            a aVar = this.aww;
            if (aVar != null) {
                aVar.bG();
            }
        } else {
            if (!TextUtils.isEmpty(adInfoEM.adBaseInfo.adSourceDescription)) {
                this.awu.setText(com.kwad.sdk.core.response.helper.a.aJ(adInfoEM));
                this.awu.setVisibility(0);
            } else {
                this.awu.setVisibility(8);
                this.awu.setText("");
            }
            if (!TextUtils.isEmpty(str)) {
                KSImageLoader.loadFeeImage(this.awv, str, adTemplate, this.hM);
                this.awv.setVisibility(0);
            } else {
                this.awv.setVisibility(8);
                this.awv.setImageDrawable(null);
                a aVar2 = this.aww;
                if (aVar2 != null) {
                    aVar2.bG();
                }
            }
        }
        viewFindViewById.setVisibility(0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Ai() {
        this.awv.setImageDrawable(getContext().getResources().getDrawable(this.awt ? R.drawable.ksad_logo_gray : R.drawable.ksad_logo_white));
    }

    public void setLogoLoadFinishListener(a aVar) {
        this.aww = aVar;
    }

    public static Bitmap a(KsLogoView ksLogoView) {
        TextView textView = ksLogoView.getTextView();
        int iCeil = ((ksLogoView.getVisibility() != 0 || textView.getText() == null || textView.getText().length() <= 0) ? 0 : ((int) Math.ceil(textView.getPaint().measureText(textView.getText().toString()))) + textView.getPaddingLeft() + textView.getPaddingRight()) + (ksLogoView.getIcon().getVisibility() == 0 ? com.kwad.sdk.c.a.a.a(ksLogoView.getContext(), 18.0f) : 0);
        int iA = com.kwad.sdk.c.a.a.a(ksLogoView.getContext(), 16.0f);
        ksLogoView.measure(iCeil, iA);
        ksLogoView.layout(0, 0, iCeil, iA);
        Bitmap bitmapCreateBitmap = Bitmap.createBitmap(ksLogoView.getWidth(), ksLogoView.getHeight(), Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(bitmapCreateBitmap);
        canvas.drawColor(0);
        ksLogoView.draw(canvas);
        return bitmapCreateBitmap;
    }
}
