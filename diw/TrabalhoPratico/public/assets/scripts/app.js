const API_URL = window.location.hostname === 'localhost' 
  ? "http://localhost:3000/destaque"
  : "/api/destaque"; // URL relativa para produção

/* --- dados do footer --- */
const dadosFooter = {
  "id": 1,
  "Nome": "Evelyn Maestre",
  "Sobre": "Técnica em informática, graduanda em Sistemas de Informação",
  "Curso": "Sistemas de Informção",
  "Turno": "Noite",
  "Contato": [
    { "Email": "evelynmaestre5@gmail.com" },
    { "Telefone": "(31) 9 8883-9964" }
  ],
  "Redes": [
    { "Instagram": "https://www.instagram.com/__izuky__/" }
  ]
};

let editarModal; // Modal global

/* --- Espera o DOM carregar --- */
document.addEventListener("DOMContentLoaded", () => {

  // Inicializa modal Bootstrap
  const modalEl = document.getElementById("editarModal");
  if (modalEl) editarModal = new bootstrap.Modal(modalEl);

  // Envio do formulário de edição
  const formEditar = document.getElementById("formEditar");
  if (formEditar) {
    formEditar.addEventListener("submit", async (e) => {
      e.preventDefault();
      await salvarEdicao();
    });
  }

  // Menu hamburger
  setupHamburgerMenu();

  inicializarFooter();
  configurarBusca();
  carregarDestaques();

  // Delegação global de eventos (funciona para novos elementos também)
  document.addEventListener("click", (e) => {

    // Fecha todos os menus ao clicar fora
    document.querySelectorAll(".menu-opcoes").forEach(m => m.classList.add("d-none"));

    // Abrir/fechar menu ⋮
    if (e.target.classList.contains("menu-btn")) {
      e.stopPropagation();
      const id = e.target.dataset.id;
      const menu = document.getElementById(`menu-${id}`);
      if (menu) menu.classList.toggle("d-none");
      return;
    }

    // Editar álbum
    if (e.target.classList.contains("edit-btn")) {
      e.stopPropagation();
      const id = e.target.dataset.id;
      editarAlbum(id);
      return;
    }

    // Excluir álbum
    if (e.target.classList.contains("delete-btn")) {
      e.stopPropagation();
      const id = e.target.dataset.id;
      excluirAlbum(id);
      return;
    }

    // Abrir detalhes do álbum
    const card = e.target.closest(".card-album");
    if (card && !e.target.closest(".acoes")) {
      const id = card.dataset.id;
      abrirAlbum(id);
    }
  });
});

/* --- Menu Hamburger --- */
function setupHamburgerMenu() {
  const hamburgerBtn = document.getElementById("menuHamburger");
  const closeBtn = document.getElementById("closeMenu");
  const sidebar = document.getElementById("sidebarMenu");

  if (hamburgerBtn) {
    hamburgerBtn.addEventListener("click", () => {
      sidebar?.classList.toggle("mobile-open");
    });
  }

  if (closeBtn) {
    closeBtn.addEventListener("click", () => {
      sidebar?.classList.remove("mobile-open");
    });
  }

  // Fechar menu ao clicar em um link
  if (sidebar) {
    sidebar.querySelectorAll(".nav-link").forEach(link => {
      link.addEventListener("click", () => {
        sidebar.classList.remove("mobile-open");
      });
    });
  }

  // Fechar menu ao clicar fora dele (em telas pequenas)
  if (sidebar) {
    document.addEventListener("click", (e) => {
      if (!e.target.closest(".sidebar") && !e.target.closest(".hamburger-btn")) {
        sidebar.classList.remove("mobile-open");
      }
    });
  }
}

/* --- Footer --- */
function inicializarFooter() {
  const footerElements = {
    nome: document.getElementById("footer-nome"),
    sobre: document.getElementById("footer-sobre"),
    curso: document.getElementById("footer-Curso"),
    turno: document.getElementById("footer-Turno")
  };

  if (footerElements.nome) footerElements.nome.textContent = `Autora: ${dadosFooter.Nome}`;
  if (footerElements.sobre) footerElements.sobre.textContent = dadosFooter.Sobre;
  if (footerElements.curso) footerElements.curso.textContent = `Curso: ${dadosFooter.Curso}`;
  if (footerElements.turno) footerElements.turno.textContent = `Turno: ${dadosFooter.Turno}`;

  const contatoDiv = document.getElementById("footer-contato");
  if (contatoDiv) {
    contatoDiv.innerHTML = "";
    dadosFooter.Contato.forEach(item => {
      if (item.Email)
        contatoDiv.innerHTML += `<p><i class="fas fa-envelope"></i> <a href="mailto:${item.Email}" class="text-light">${item.Email}</a></p>`;
      if (item.Telefone)
        contatoDiv.innerHTML += `<p><i class="fas fa-phone"></i> ${item.Telefone}</p>`;
    });
  }

  const redesDiv = document.getElementById("footer-redes");
  if (redesDiv) {
    redesDiv.innerHTML = "";
    dadosFooter.Redes.forEach(rede => {
      if (rede.Instagram)
        redesDiv.innerHTML += `<p><i class="fab fa-instagram"></i> <a href="${rede.Instagram}" target="_blank" class="text-light">Instagram</a></p>`;
    });
  }
}

/* --- Campo de busca --- */
function configurarBusca() {
  const btnBusca = document.getElementById('btnBusca');
  const campoBusca = document.getElementById('campoBusca');
  
  if (btnBusca && campoBusca) {
    btnBusca.addEventListener('click', () => {
      campoBusca.style.display = campoBusca.style.display === 'none' ? 'inline-block' : 'none';
      if (campoBusca.style.display === 'inline-block') campoBusca.focus();
    });
  }
}

/* --- Função de pesquisa --- */
function pesquisar() {
  const campoBusca = document.getElementById('campoBusca');
  const termo = campoBusca.value.toLowerCase().trim();
  const cards = document.querySelectorAll('.card-album');
  let encontrados = 0;

  cards.forEach(card => {
    const titulo = card.querySelector('.card-title')?.textContent.toLowerCase() || '';
    const ano = card.querySelector('.card-text')?.textContent.toLowerCase() || '';
    
    if (titulo.includes(termo) || ano.includes(termo) || termo === '') {
      card.parentElement.style.display = 'block';
      encontrados++;
    } else {
      card.parentElement.style.display = 'none';
    }
  });

  // Mostra mensagem se nenhum resultado encontrado
  const container = document.getElementById('destaques');
  if (container && encontrados === 0 && termo !== '') {
    const existeMsg = container.querySelector('.no-results-msg');
    if (!existeMsg) {
      const msg = document.createElement('div');
      msg.className = 'no-results-msg col-12 text-center text-light mt-4';
      msg.innerHTML = `<p>Nenhum álbum encontrado para "<strong>${termo}</strong>"</p>`;
      container.appendChild(msg);
    }
  } else {
    const existeMsg = container?.querySelector('.no-results-msg');
    if (existeMsg) existeMsg.remove();
  }
}

/* --- Carrega cards --- */
async function carregarDestaques() {
  try {
    const resp = await fetch(API_URL);
    if (!resp.ok) throw new Error(`HTTP ${resp.status}`);
    const destaque = await resp.json();

    const container = document.getElementById("destaques");
    if (!container) return;

    container.innerHTML = "";


    destaque.forEach(album => {
      const col = document.createElement("div");
      col.className = "col-md-4";
      col.innerHTML = `
        <div class="card bg-dark text-white h-100 card-album" data-id="${album.id}" style="cursor:pointer; position:relative;">
          <div class="acoes position-absolute top-0 end-0 m-2">
            <button class="btn btn-dark btn-sm menu-btn" data-id="${album.id}">⋮</button>
            <div class="menu-opcoes bg-dark border rounded p-2 d-none" id="menu-${album.id}">
              <button class="btn btn-warning btn-sm w-100 mb-1 edit-btn" data-id="${album.id}">✏️ Editar</button>
              <button class="btn btn-danger btn-sm w-100 delete-btn" data-id="${album.id}">🗑️ Excluir</button>
            </div>
          </div>
          <img src="${album.imagem}" class="card-img-top" alt="${album.album}">
          <div class="card-body">
            <h5 class="card-title">${album.album}</h5>
            <p class="card-text">Lançamento: ${album.lancamento}</p>
          </div>
        </div>
      `;
      container.appendChild(col);
    });

  } catch (erro) {
    console.error("Erro ao carregar destaques:", erro);
    const container = document.getElementById("destaques");
    if (container) container.innerHTML = '<p>Erro ao carregar álbuns. Verifique o servidor.</p>';
  }
}

/* --- Abre página de detalhes --- */
function abrirAlbum(id) {
  window.location.href = `detalhes.html?id=${id}`;
}

/* --- Edição --- */
async function editarAlbum(id) {
  try {
    const resp = await fetch(`${API_URL}/${id}`);
    if (!resp.ok) throw new Error("Erro ao buscar álbum");
    const album = await resp.json();

    // Coleta todos os campos necessários
    const campos = {
      id: document.getElementById("editId"),
      nome: document.getElementById("editNome"),
      ano: document.getElementById("editAno"),
      imagem: document.getElementById("editImagem"),
      info: document.getElementById("editInfo")
    };

    // Verifica se todos os campos existem
    if (!campos.id || !campos.nome || !campos.ano || !campos.imagem || !campos.info) {
      throw new Error("Campos do formulário não encontrados");
    }

    // Preenche os campos
    campos.id.value = album.id;
    campos.nome.value = album.album;
    campos.ano.value = album.lancamento;
    campos.imagem.value = album.imagem;
    campos.info.value = album.informacoes;

    if (!editarModal) {
      throw new Error("Modal não inicializado");
    }
    editarModal.show();
  } catch (err) {
    console.error("Erro ao abrir o modal de edição:", err);
    alert("Erro ao abrir o modal de edição: " + err.message);
  }
}

/* --- Salvar edição --- */
async function salvarEdicao() {
  try {
    // Coleta e valida todos os campos
    const campos = {
      id: document.getElementById("editId"),
      nome: document.getElementById("editNome"),
      ano: document.getElementById("editAno"),
      imagem: document.getElementById("editImagem"),
      info: document.getElementById("editInfo")
    };

    // Verifica se todos os campos existem
    for (const [nome, campo] of Object.entries(campos)) {
      if (!campo) throw new Error(`Campo ${nome} não encontrado`);
    }

    const id = campos.id.value;
    const albumAtualizado = {
      album: campos.nome.value,
      lancamento: campos.ano.value,
      imagem: campos.imagem.value,
      informacoes: campos.info.value
    };

    const resp = await fetch(`${API_URL}/${id}`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(albumAtualizado)
    });
    if (!resp.ok) throw new Error("Erro ao atualizar álbum");

    alert("Álbum atualizado com sucesso!");
    editarModal.hide();
    carregarDestaques();
  } catch (err) {
    console.error("Erro ao salvar alterações:", err);
    alert("Erro ao salvar alterações.");
  }
}

/* --- Excluir álbum --- */
async function excluirAlbum(id) {
  const confirmar = confirm("Tem certeza que deseja excluir este álbum?");
  if (!confirmar) return;

  try {
    const resp = await fetch(`${API_URL}/${id}`, { method: "DELETE" });
    if (!resp.ok) throw new Error("Erro ao excluir álbum");

    alert("Álbum excluído com sucesso!");
    carregarDestaques();
  } catch (err) {
    console.error("Erro ao excluir álbum:", err);
    alert("Erro ao excluir o álbum.");
  }
}

/* --- Adicionar faixa a um álbum (somente página de detalhes) --- */
async function adicionarFaixa(albumId, faixa) {
  try {
    const resp = await fetch(`${API_URL}/${albumId}`);
    if (!resp.ok) throw new Error('Álbum não encontrado');
    const album = await resp.json();

    album.faixas = album.faixas || [];
    // gerar id simples para a faixa (maior id atual + 1)
    const maxId = album.faixas.reduce((m, f) => Math.max(m, (f.id || 0)), 0);
    const novaFaixa = Object.assign({ id: maxId + 1 }, faixa);
    album.faixas.push(novaFaixa);

    const put = await fetch(`${API_URL}/${albumId}`, {
      method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(album)
    });
    if (!put.ok) throw new Error('Erro ao adicionar faixa');

    // Atualiza a página de detalhes (recarrega para simplicidade)
    if (window.location.pathname.endsWith('detalhes.html')) {
      location.reload();
    }
    return true;
  } catch (err) {
    console.error('Erro ao adicionar faixa:', err);
    alert('Erro ao adicionar faixa.');
    return false;
  }
}

/* --- Excluir faixa de um álbum (somente página de detalhes) --- */
async function excluirFaixa(albumId, faixaId) {
  const confirmar = confirm('Tem certeza que deseja excluir esta faixa?');
  if (!confirmar) return;

  try {
    const resp = await fetch(`${API_URL}/${albumId}`);
    if (!resp.ok) throw new Error('Álbum não encontrado');
    const album = await resp.json();

    album.faixas = (album.faixas || []).filter(f => String(f.id) !== String(faixaId));

    const put = await fetch(`${API_URL}/${albumId}`, {
      method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(album)
    });
    if (!put.ok) throw new Error('Erro ao excluir faixa');

    if (window.location.pathname.endsWith('detalhes.html')) {
      location.reload();
    }
    return true;
  } catch (err) {
    console.error('Erro ao excluir faixa:', err);
    alert('Erro ao excluir a faixa.');
    return false;
  }
}

// Tornar as funções acessíveis globalmente para o código inline em `detalhes.html`
window.adicionarFaixa = adicionarFaixa;
window.excluirFaixa = excluirFaixa;

/* --- Atualizar (editar) uma faixa existente --- */
async function atualizarFaixa(albumId, faixaId, dados) {
  try {
    const resp = await fetch(`${API_URL}/${albumId}`);
    if (!resp.ok) throw new Error('Álbum não encontrado');
    const album = await resp.json();

    const idx = (album.faixas || []).findIndex(f => String(f.id) === String(faixaId));
    if (idx === -1) throw new Error('Faixa não encontrada');

    // Atualiza somente campos permitidos
    album.faixas[idx] = Object.assign({}, album.faixas[idx], dados);

    const put = await fetch(`${API_URL}/${albumId}`, {
      method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(album)
    });
    if (!put.ok) throw new Error('Erro ao atualizar faixa');

    if (window.location.pathname.endsWith('detalhes.html')) {
      location.reload();
    }
    return true;
  } catch (err) {
    console.error('Erro ao atualizar faixa:', err);
    alert('Erro ao atualizar a faixa.');
    return false;
  }
}

window.atualizarFaixa = atualizarFaixa;
