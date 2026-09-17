package com.kwad.components.ad.reward.presenter;

import android.graphics.BitmapFactory;
import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.DisplayImageOptionsCompat;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener;
import com.kwad.sdk.core.imageloader.utils.BlurUtils;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import java.io.InputStream;

/* JADX INFO: loaded from: classes3.dex */
public class c extends b {
    private ImageView wo;
    private AdInfo wp;

    public c(AdInfo adInfo) {
        this.wp = adInfo;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.wo = (ImageView) findViewById(iM());
    }

    protected int iM() {
        return R.id.ksad_blur_video_cover;
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.ub.mAdTemplate;
        if (iL() || adTemplate.adInfoList.size() <= 0) {
            return;
        }
        String strAa = com.kwad.sdk.core.response.helper.a.aa(adTemplate.adInfoList.get(0));
        this.wo.setVisibility(iN());
        try {
            a(this.wo, strAa, adTemplate);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }

    protected int iN() {
        getContext();
        if (com.kwad.components.ad.reward.g.O(this.ub.mAdTemplate) && !as.VV()) {
            return 0;
        }
        if (com.kwad.components.ad.reward.g.N(this.ub.mAdTemplate) && !as.VV()) {
            return 0;
        }
        if ((!com.kwad.sdk.core.response.helper.e.eY(this.ub.mAdTemplate) || as.VV()) && !com.kwad.components.ad.reward.g.g(this.wp)) {
            return (com.kwad.sdk.core.response.helper.a.cQ(this.wp) && com.kwad.components.ad.reward.a.b.hW() && !as.VV()) ? 0 : 8;
        }
        return 0;
    }

    private static void a(ImageView imageView, String str, AdTemplate adTemplate) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        KSImageLoader.loadImage(imageView, str, adTemplate, new DisplayImageOptionsCompat.Builder().setBlurRadius(50).build(), new SimpleImageLoadingListener() { // from class: com.kwad.components.ad.reward.presenter.c.1
            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final void onLoadingComplete(String str2, View view, DecodedResult decodedResult) {
            }

            @Override // com.kwad.sdk.core.imageloader.core.listener.SimpleImageLoadingListener, com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
            public final boolean onDecode(String str2, InputStream inputStream, DecodedResult decodedResult) {
                decodedResult.mBitmap = BlurUtils.stackBlur(BitmapFactory.decodeStream(inputStream), 50, false);
                return true;
            }
        });
    }
}
