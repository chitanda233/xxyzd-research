package com.kwad.components.core.b;

import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements View.OnClickListener {
    private TextView OQ;
    private ImageView OR;
    private ImageView OS;
    private InterfaceC0417a OT;
    private ViewGroup wL;

    /* JADX INFO: renamed from: com.kwad.components.core.b.a$a, reason: collision with other inner class name */
    public interface InterfaceC0417a {
        void w(View view);

        void x(View view);
    }

    public a(ViewGroup viewGroup) {
        if (viewGroup == null) {
            return;
        }
        ViewGroup viewGroup2 = (ViewGroup) viewGroup.findViewById(R.id.ksad_kwad_web_title_bar);
        this.wL = viewGroup2;
        if (viewGroup2 == null) {
            return;
        }
        initView();
    }

    private void initView() {
        this.OQ = (TextView) this.wL.findViewById(R.id.ksad_kwad_titlebar_title);
        this.OR = (ImageView) this.wL.findViewById(R.id.ksad_kwad_web_navi_back);
        ImageView imageView = (ImageView) this.wL.findViewById(R.id.ksad_kwad_web_navi_close);
        this.OS = imageView;
        imageView.setOnClickListener(this);
        this.OR.setOnClickListener(this);
    }

    public final void a(InterfaceC0417a interfaceC0417a) {
        this.OT = interfaceC0417a;
    }

    public final void a(b bVar) {
        TextView textView;
        com.kwad.sdk.core.d.c.d("KsTitleBarHelper", "bindView call model: " + bVar.toString());
        if (this.wL == null || bVar == null || (textView = this.OQ) == null) {
            return;
        }
        textView.setText(bVar.getTitle());
        int iOD = bVar.oD();
        if (iOD >= 0) {
            this.OQ.setTextColor(iOD);
        }
        int iOE = bVar.oE();
        if (iOE >= 0) {
            this.OQ.setBackgroundColor(iOE);
        }
    }

    public final void ak(boolean z) {
        ImageView imageView = this.OS;
        if (imageView != null) {
            imageView.setVisibility(z ? 0 : 8);
        }
    }

    public final void al(boolean z) {
        ImageView imageView = this.OR;
        if (imageView != null) {
            imageView.setVisibility(8);
        }
    }

    public final ViewGroup hZ() {
        return this.wL;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.OT == null) {
            return;
        }
        if (view.equals(this.OS)) {
            this.OT.x(view);
        } else if (view.equals(this.OR)) {
            this.OT.w(view);
        }
    }
}
