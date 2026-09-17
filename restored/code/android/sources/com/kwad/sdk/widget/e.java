package com.kwad.sdk.widget;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends c {
    private b btn;
    private String bto;
    private String btp;
    private int btq;
    private String btr;
    private int bts;

    public interface b {
        void a(DialogInterface dialogInterface);

        void b(DialogInterface dialogInterface);

        void c(DialogInterface dialogInterface);
    }

    public e(a aVar) {
        super(aVar.mContext);
        a(aVar);
    }

    private void a(a aVar) {
        int color;
        int color2;
        if (aVar.mContext instanceof Activity) {
            setOwnerActivity((Activity) aVar.mContext);
        }
        this.btn = aVar.btn;
        this.bto = aVar.bto;
        this.btp = !TextUtils.isEmpty(aVar.btp) ? aVar.btp : aVar.mContext.getString(R.string.ksad_no_title_common_dialog_positivebtn_title);
        if (aVar.btq == 0) {
            color = aVar.mContext.getResources().getColor(R.color.ksad_no_title_common_dialog_positivebtn_color);
        } else {
            color = aVar.btq;
        }
        this.btq = color;
        this.btr = !TextUtils.isEmpty(aVar.btr) ? aVar.btr : aVar.mContext.getString(R.string.ksad_no_title_common_dialog_negativebtn_title);
        if (aVar.bts == 0) {
            color2 = aVar.mContext.getResources().getColor(R.color.ksad_no_title_common_dialog_negativebtn_color);
        } else {
            color2 = aVar.bts;
        }
        this.bts = color2;
    }

    @Override // android.app.Dialog
    protected final void onCreate(Bundle bundle) {
        try {
            super.onCreate(bundle);
            requestWindowFeature(1);
            setContentView(vg());
            setCanceledOnTouchOutside(true);
            getWindow().setBackgroundDrawable(new ColorDrawable(0));
            getWindow().setLayout(-1, -1);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private View vg() {
        View viewInflate = LayoutInflater.from(m.wrapContextIfNeed(getContext())).inflate(R.layout.ksad_no_title_common_dialog_content_layout, (ViewGroup) null, false);
        viewInflate.findViewById(R.id.ksad_no_title_common_dialog_layout).setOnClickListener(new View.OnClickListener() { // from class: com.kwad.sdk.widget.e.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (e.this.btn != null) {
                    e.this.btn.c(e.this);
                }
            }
        });
        TextView textView = (TextView) viewInflate.findViewById(R.id.ksad_no_title_common_positive_btn);
        if (!TextUtils.isEmpty(this.btp)) {
            textView.setText(this.btp);
        }
        textView.setTextColor(this.btq);
        textView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.sdk.widget.e.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (e.this.btn != null) {
                    e.this.btn.a(e.this);
                }
            }
        });
        TextView textView2 = (TextView) viewInflate.findViewById(R.id.ksad_no_title_common_negative_btn);
        if (!TextUtils.isEmpty(this.btr)) {
            textView2.setText(this.btr);
        }
        textView2.setTextColor(this.bts);
        textView2.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.sdk.widget.e.3
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                if (e.this.btn != null) {
                    e.this.btn.b(e.this);
                }
            }
        });
        ((TextView) viewInflate.findViewById(R.id.ksad_no_title_common_content_text)).setText(this.bto);
        return viewInflate;
    }

    public static class a {
        private b btn;
        private String bto;
        private String btp;
        private int btq;
        private String btr;
        private int bts;
        private Context mContext;

        public a(Context context) {
            this.mContext = context;
        }

        public final a iz(String str) {
            this.bto = str;
            return this;
        }

        public final a iA(String str) {
            this.btp = str;
            return this;
        }

        public final a iB(String str) {
            this.btr = str;
            return this;
        }

        public final a a(b bVar) {
            this.btn = bVar;
            return this;
        }

        public final e XR() {
            return new e(this);
        }
    }
}
