package com.kwad.sdk.mvp;

import android.app.Activity;
import android.content.Context;
import android.view.View;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.d;
import com.kwad.sdk.wrapper.m;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public class Presenter {
    private Object bjo;
    private View mRootView;
    private final List<Presenter> bjn = new CopyOnWriteArrayList();
    private PresenterState bjp = PresenterState.INIT;

    protected void av() {
    }

    protected void onCreate() {
    }

    protected void onDestroy() {
    }

    protected void onUnbind() {
    }

    public final void N(View view) {
        try {
            this.bjp = PresenterState.CREATE;
            this.mRootView = view;
            onCreate();
            this.bjp.performCallState(this);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void q(Object obj) {
        try {
            if (this.bjp != PresenterState.INIT) {
                PresenterState presenterState = PresenterState.DESTROY;
            }
            if (this.bjp == PresenterState.BIND) {
                ob();
            }
            this.bjp = PresenterState.BIND;
            this.bjo = obj;
            av();
            this.bjp.performCallState(this);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void ob() {
        try {
            this.bjp = PresenterState.UNBIND;
            onUnbind();
            this.bjp.performCallState(this);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void destroy() {
        try {
            if (this.bjp == PresenterState.BIND) {
                ob();
            }
            this.bjp = PresenterState.DESTROY;
            onDestroy();
            this.bjp.performCallState(this);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void a(Presenter presenter) {
        this.bjn.add(presenter);
        if (!SI() || presenter.SI()) {
            return;
        }
        N(this.mRootView);
    }

    public final void a(Presenter presenter, boolean z) {
        this.bjn.add(presenter);
        try {
            b(presenter);
        } catch (Throwable th) {
            d.gatherException(th);
            c.printStackTrace(th);
        }
    }

    private void b(Presenter presenter) {
        Object obj;
        View view;
        if (this.bjp.index() >= PresenterState.UNBIND.index() || presenter.bjp.index() >= PresenterState.UNBIND.index()) {
            return;
        }
        if (SI() && !presenter.SI() && (view = this.mRootView) != null) {
            presenter.N(view);
        }
        if (!isBound() || !presenter.SI() || presenter.isBound() || (obj = this.bjo) == null) {
            return;
        }
        presenter.q(obj);
    }

    private boolean SI() {
        return this.bjp.index() >= PresenterState.CREATE.index();
    }

    private boolean isBound() {
        return this.bjp == PresenterState.BIND;
    }

    public final View getRootView() {
        return this.mRootView;
    }

    public final List<Presenter> SJ() {
        return this.bjn;
    }

    public final Activity getActivity() {
        return m.getActivityFromContext(getContext());
    }

    public final Object SK() {
        return this.bjo;
    }

    public final Context getContext() {
        return this.mRootView.getContext();
    }

    public final <T extends View> T findViewById(int i) {
        return (T) this.mRootView.findViewById(i);
    }

    /* JADX WARN: Enum visitor error
    jadx.core.utils.exceptions.JadxRuntimeException: Init of enum field 'INIT' uses external variables
    	at jadx.core.dex.visitors.EnumVisitor.createEnumFieldByConstructor(EnumVisitor.java:485)
    	at jadx.core.dex.visitors.EnumVisitor.processEnumFieldByRegister(EnumVisitor.java:422)
    	at jadx.core.dex.visitors.EnumVisitor.extractEnumFieldsFromFilledArray(EnumVisitor.java:351)
    	at jadx.core.dex.visitors.EnumVisitor.extractEnumFieldsFromInsn(EnumVisitor.java:284)
    	at jadx.core.dex.visitors.EnumVisitor.convertToEnum(EnumVisitor.java:153)
    	at jadx.core.dex.visitors.EnumVisitor.visit(EnumVisitor.java:102)
     */
    /* JADX WARN: Failed to restore enum class, 'enum' modifier and super class removed */
    static abstract class PresenterState {
        private static final /* synthetic */ PresenterState[] $VALUES;
        public static final PresenterState BIND;
        public static final PresenterState CREATE;
        public static final PresenterState DESTROY;
        public static final PresenterState INIT;
        public static final PresenterState UNBIND;
        private int mIndex;

        abstract void performCallState(Presenter presenter);

        public static PresenterState valueOf(String str) {
            return (PresenterState) Enum.valueOf(PresenterState.class, str);
        }

        public static PresenterState[] values() {
            return (PresenterState[]) $VALUES.clone();
        }

        static {
            int i = 0;
            PresenterState presenterState = new PresenterState("INIT", i, i) { // from class: com.kwad.sdk.mvp.Presenter.PresenterState.1
                @Override // com.kwad.sdk.mvp.Presenter.PresenterState
                public final void performCallState(Presenter presenter) {
                }
            };
            INIT = presenterState;
            int i2 = 1;
            PresenterState presenterState2 = new PresenterState("CREATE", i2, i2) { // from class: com.kwad.sdk.mvp.Presenter.PresenterState.2
                @Override // com.kwad.sdk.mvp.Presenter.PresenterState
                public final void performCallState(Presenter presenter) {
                    Iterator it = presenter.bjn.iterator();
                    while (it.hasNext()) {
                        try {
                            ((Presenter) it.next()).N(presenter.mRootView);
                        } catch (Exception e) {
                            d.gatherException(e);
                            c.printStackTrace(e);
                        }
                    }
                }
            };
            CREATE = presenterState2;
            int i3 = 2;
            PresenterState presenterState3 = new PresenterState("BIND", i3, i3) { // from class: com.kwad.sdk.mvp.Presenter.PresenterState.3
                @Override // com.kwad.sdk.mvp.Presenter.PresenterState
                final void performCallState(Presenter presenter) {
                    Iterator it = presenter.bjn.iterator();
                    while (it.hasNext()) {
                        try {
                            ((Presenter) it.next()).q(presenter.bjo);
                        } catch (Throwable th) {
                            d.gatherException(th);
                            c.printStackTrace(th);
                        }
                    }
                }
            };
            BIND = presenterState3;
            int i4 = 3;
            PresenterState presenterState4 = new PresenterState("UNBIND", i4, i4) { // from class: com.kwad.sdk.mvp.Presenter.PresenterState.4
                @Override // com.kwad.sdk.mvp.Presenter.PresenterState
                final void performCallState(Presenter presenter) {
                    Iterator it = presenter.bjn.iterator();
                    while (it.hasNext()) {
                        try {
                            ((Presenter) it.next()).ob();
                        } catch (Exception e) {
                            d.gatherException(e);
                            c.printStackTrace(e);
                        }
                    }
                }
            };
            UNBIND = presenterState4;
            int i5 = 4;
            PresenterState presenterState5 = new PresenterState("DESTROY", i5, i5) { // from class: com.kwad.sdk.mvp.Presenter.PresenterState.5
                @Override // com.kwad.sdk.mvp.Presenter.PresenterState
                final void performCallState(Presenter presenter) {
                    Iterator it = presenter.bjn.iterator();
                    while (it.hasNext()) {
                        try {
                            ((Presenter) it.next()).destroy();
                        } catch (Exception e) {
                            d.gatherException(e);
                            c.printStackTrace(e);
                        }
                    }
                }
            };
            DESTROY = presenterState5;
            $VALUES = new PresenterState[]{presenterState, presenterState2, presenterState3, presenterState4, presenterState5};
        }

        private PresenterState(String str, int i, int i2) {
            super(str, i);
            this.mIndex = i2;
        }

        public int index() {
            return this.mIndex;
        }
    }
}
