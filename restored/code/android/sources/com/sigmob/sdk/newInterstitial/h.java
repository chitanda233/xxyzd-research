package com.sigmob.sdk.newInterstitial;

import android.content.Context;
import android.graphics.Bitmap;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.ImageManager;
import com.czhj.sdk.common.utils.ResourceUtil;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.base.views.s;
import com.sigmob.sdk.base.views.w;

/* JADX INFO: loaded from: classes4.dex */
public class h extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ImageView f3604a;
    private ImageView b;
    private TextView c;
    private TextView d;
    private Button e;
    private ImageView f;
    private SigAdPrivacyInfoView g;
    private w h;
    private View i;

    public h(Context context) {
        super(context);
        a(context);
    }

    public h(Context context, AttributeSet attrs) {
        super(context, attrs);
        a(context);
    }

    public h(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        a(context);
    }

    private void a(Context context) {
        View viewInflate = inflate(context, ResourceUtil.getLayoutId(context, "sig_new_interstitial_endcard_layout"), this);
        this.i = viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_rl_close"));
        ImageView imageView = (ImageView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_close"));
        this.f3604a = imageView;
        if (v.b(imageView)) {
            this.f3604a.setImageBitmap(s.CLOSE_OLD.a());
        }
        this.b = (ImageView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_app_icon"));
        this.c = (TextView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_title"));
        this.d = (TextView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_desc"));
        this.e = (Button) viewInflate.findViewById(ResourceUtil.getId(context, "sig_cta_button"));
        this.f = (ImageView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_endCard_image"));
        this.g = (SigAdPrivacyInfoView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_privacy_info"));
    }

    public void a(View.OnClickListener onClickListener) {
        if (this.h == null) {
            Context context = getContext();
            w wVar = new w(context);
            this.h = wVar;
            wVar.setText("反馈");
            this.h.setOnClickListener(onClickListener);
            this.h.setId(ClientMetadata.generateViewId());
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(Dips.dipsToIntPixels(45.0f, context), Dips.dipsToIntPixels(30.0f, context));
            layoutParams.addRule(0, this.i.getId());
            layoutParams.addRule(8, this.i.getId());
            ViewParent parent = this.i.getParent();
            if (parent == null) {
                return;
            }
            ((ViewGroup) parent).addView(this.h, layoutParams);
        }
    }

    public void a(String iconUrl, String imageUrl, String title, String description, String ctaTitle) {
        if (com.sigmob.sdk.base.utils.s.b(iconUrl)) {
            com.sigmob.sdk.base.common.h.a().load(iconUrl).into(this.b);
        }
        if (com.sigmob.sdk.base.utils.s.b(imageUrl) || com.sigmob.sdk.base.utils.s.b(iconUrl)) {
            if (!com.sigmob.sdk.base.utils.s.a((CharSequence) imageUrl)) {
                iconUrl = imageUrl;
            }
            com.sigmob.sdk.base.common.h.a().getBitmap(iconUrl, new ImageManager.BitmapLoadedListener() { // from class: com.sigmob.sdk.newInterstitial.h.1
                @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
                public void onBitmapLoadFailed() {
                }

                @Override // com.czhj.sdk.common.utils.ImageManager.BitmapLoadedListener
                public void onBitmapLoaded(Bitmap bitmap) {
                    if (bitmap == null) {
                        return;
                    }
                    com.sigmob.sdk.base.blurkit.a.a(h.this.getContext());
                    Bitmap bitmapA = com.sigmob.sdk.base.blurkit.a.a().a(bitmap.copy(bitmap.getConfig(), true), 25);
                    if (bitmapA == null) {
                        return;
                    }
                    h.this.f.setImageBitmap(bitmapA);
                }
            });
        }
        if (com.sigmob.sdk.base.utils.s.b(title)) {
            this.c.setText(title);
        }
        if (com.sigmob.sdk.base.utils.s.b(description)) {
            this.d.setText(description);
        }
        if (com.sigmob.sdk.base.utils.s.b(ctaTitle)) {
            this.e.setText(ctaTitle);
        }
    }

    public SigAdPrivacyInfoView getAdPrivacyInfo() {
        return this.g;
    }

    public Button getCTAButton() {
        return this.e;
    }

    public View getCloseButton() {
        return this.f3604a;
    }
}
