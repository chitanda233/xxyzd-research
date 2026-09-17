package com.sigmob.sdk.newInterstitial;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.czhj.sdk.common.utils.ResourceUtil;
import com.sigmob.sdk.base.utils.s;

/* JADX INFO: loaded from: classes4.dex */
public class SigAdInfoView extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ImageView f3601a;
    private TextView b;
    private TextView c;
    private SigAdPrivacyInfoView d;
    private boolean e;

    public SigAdInfoView(Context context) {
        super(context);
        this.e = false;
        a(context);
    }

    public SigAdInfoView(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.e = false;
        this.e = attrs.getAttributeBooleanValue(null, "sig_isSmall", false);
        a(context);
    }

    public SigAdInfoView(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.e = false;
        a(context);
    }

    private void a(Context context) {
        View viewInflate = inflate(context, ResourceUtil.getLayoutId(context, this.e ? "sig_ad_app_info_small_layout" : "sig_ad_app_info_layout"), this);
        this.f3601a = (ImageView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_app_icon"));
        this.b = (TextView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_title"));
        this.c = (TextView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_desc"));
        this.d = (SigAdPrivacyInfoView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_privacy_info"));
    }

    public SigAdPrivacyInfoView getAdPrivacyInfo() {
        return this.d;
    }

    public void setAppInfoView(String iconUrl, String title, String desc) {
        if (s.b(iconUrl)) {
            com.sigmob.sdk.base.common.h.a().load(iconUrl).into(this.f3601a);
        }
        if (s.b(title)) {
            this.b.setText(title);
        }
        if (s.b(desc)) {
            this.c.setText(desc);
        }
    }
}
