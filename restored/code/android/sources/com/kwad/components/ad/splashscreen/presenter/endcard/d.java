package com.kwad.components.ad.splashscreen.presenter.endcard;

import android.graphics.BitmapFactory;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.widget.ImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.DisplayImageOptionsCompat;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener;
import com.kwad.sdk.core.imageloader.utils.BlurUtils;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.io.InputStream;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.splashscreen.presenter.e implements com.kwad.sdk.core.j.c {
    private ViewGroup JM;
    private ImageView JN;
    private SplashEndLandView JO;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        initView();
        this.Hu.GH.a(this);
        com.kwad.sdk.core.adlog.c.d(this.Hu.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().dU(87).eb(6));
        nj();
        nk();
    }

    private void nj() {
        if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate))) {
            com.kwad.components.ad.splashscreen.e.a aVar = new com.kwad.components.ad.splashscreen.e.a(getContext(), this.Hu.mAdTemplate) { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.d.1
                {
                    super(adTemplate);
                }

                @Override // com.kwad.components.ad.splashscreen.e.a
                public final void j(int i, String str) {
                    d.this.ad(str);
                }
            };
            if (this.Hu.mApkDownloadHelper != null) {
                this.Hu.mApkDownloadHelper.b(aVar);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ad(String str) {
        SplashEndLandView splashEndLandView = this.JO;
        if (splashEndLandView == null || str == null) {
            return;
        }
        splashEndLandView.ad(str);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        SplashEndLandView splashEndLandView = this.JO;
        if (splashEndLandView != null) {
            splashEndLandView.nl();
        }
        this.Hu.GH.b(this);
    }

    private void initView() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_splash_endcard_view_stub);
        if (viewStub != null) {
            this.JM = (ViewGroup) viewStub.inflate();
        } else {
            this.JM = (ViewGroup) findViewById(R.id.ksad_splash_end_card_native_root);
        }
        boolean zDv = com.kwad.sdk.core.response.helper.a.dv(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        if (zDv) {
            this.JM.post(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.d.2
                @Override // java.lang.Runnable
                public final void run() {
                    d.this.JM.getWidth();
                    d.this.JO.a(d.this.Hu.mAdTemplate, d.this.Hu.mApkDownloadHelper, com.kwad.sdk.c.a.a.px2dip(d.this.getContext(), d.this.JM.getHeight()) / 414.0f);
                }
            });
        }
        this.JN = (ImageView) findViewById(R.id.ksad_splash_end_card_native_bg);
        SplashEndLandView splashEndLandView = (SplashEndLandView) findViewById(R.id.ksad_splash_end_card_native_dialog_root);
        this.JO = splashEndLandView;
        splashEndLandView.t(zDv);
        this.JO.a(this.Hu.mAdTemplate, this.Hu.mApkDownloadHelper, 1.0f);
    }

    private void nk() {
        this.JM.setVisibility(0);
        a(this.JN, com.kwad.sdk.core.response.helper.a.ba(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate)).materialUrl, this.Hu.mAdTemplate);
    }

    private static void a(ImageView imageView, String str, AdTemplate adTemplate) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        KSImageLoader.loadImage(imageView, str, adTemplate, new DisplayImageOptionsCompat.Builder().setBlurRadius(20).build(), new SimpleImageLoadingListener() { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.d.3
            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final void onLoadingComplete(String str2, View view, DecodedResult decodedResult) {
            }

            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final boolean onDecode(String str2, InputStream inputStream, DecodedResult decodedResult) {
                decodedResult.mBitmap = BlurUtils.stackBlur(BitmapFactory.decodeStream(inputStream), 20, false);
                return true;
            }
        });
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        SplashEndLandView splashEndLandView = this.JO;
        if (splashEndLandView != null) {
            splashEndLandView.bv();
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        SplashEndLandView splashEndLandView = this.JO;
        if (splashEndLandView != null) {
            splashEndLandView.bw();
        }
    }
}
