package com.bytedance.android;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.alipay.sdk.m.c0.d;

/* JADX INFO: loaded from: classes2.dex */
class BannerView extends FrameLayout {
    private final Context mContext;
    private Button mCreateButton;
    private Button mDislikeButton;
    private ImageView mImageView;
    private TextView mTitle;

    public BannerView(Context context) {
        super(context);
        this.mContext = context;
        init();
    }

    public BannerView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.mContext = context;
        init();
    }

    public BannerView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mContext = context;
        init();
    }

    private void init() {
        ImageView imageView = new ImageView(this.mContext);
        this.mImageView = imageView;
        imageView.setLayoutParams(new FrameLayout.LayoutParams(-1, -1));
        this.mImageView.setScaleType(ImageView.ScaleType.FIT_XY);
        addView(this.mImageView, new FrameLayout.LayoutParams(-1, -1));
        initTitle();
        initCreateButton();
        initDislike();
    }

    private void initDislike() {
        Button button = new Button(this.mContext);
        this.mDislikeButton = button;
        button.setText("关闭");
        this.mDislikeButton.setTextColor(-16777216);
        this.mDislikeButton.setTextSize(10.0f);
        this.mDislikeButton.setBackgroundColor(-7829368);
        this.mDislikeButton.setOnClickListener(new View.OnClickListener() { // from class: com.bytedance.android.BannerView.1
            @Override // android.view.View.OnClickListener
            public void onClick(View view) {
            }
        });
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(110, 100);
        layoutParams.gravity = 53;
        layoutParams.topMargin = 20;
        layoutParams.rightMargin = 20;
        addView(this.mDislikeButton, layoutParams);
    }

    private void initTitle() {
        TextView textView = new TextView(this.mContext);
        this.mTitle = textView;
        textView.setText(d.w);
        this.mTitle.setTextColor(-1);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
        layoutParams.gravity = 51;
        layoutParams.topMargin = 20;
        layoutParams.rightMargin = 20;
        addView(this.mTitle, layoutParams);
    }

    private void initCreateButton() {
        Button button = new Button(this.mContext);
        this.mCreateButton = button;
        button.setText("查看详情");
        this.mCreateButton.setTextColor(-16777216);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
        layoutParams.gravity = 85;
        layoutParams.topMargin = 20;
        layoutParams.rightMargin = 20;
        addView(this.mCreateButton, layoutParams);
    }

    ImageView getImageView() {
        return this.mImageView;
    }

    void setTitle(String str) {
        this.mTitle.setText(str);
    }

    Button getCreateButton() {
        return this.mCreateButton;
    }

    public View getDisLikeView() {
        return this.mDislikeButton;
    }
}
